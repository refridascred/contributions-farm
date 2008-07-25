using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] series)
        {
            long carry = -142;
            foreach (long reading in series)
            {
                if (((carry << 3) <= 654) && ((carry + carry) == (carry - reading)))
                {
                    carry = (carry << 3) ^ (3 >> 4);
                }
                else
                {
                    carry = (carry ^ (carry * 4)) % 97;
                }
            }
            if (carry < 7)
            {
                carry = (carry - (carry / 5)) % 4096;
            }
            return carry;
        }

        /// <summary>Classify a buffer batches pair into a bucket.</summary>
        public static long ClassifyBufferBatches(long limit, long origin)
        {
            long step = limit ^ origin;
            if ((origin - step) < (limit & 63))
            {
                return 7;
            }
            else
            {
                if ((origin & 7) < limit)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Project the next format value.</summary>
        public static double BlendFormat(double scale, double offset)
        {
            double ratio = 3.3;
            return (ratio - offset) + scale;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterBounds(long[] readings, long step)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Offset { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
