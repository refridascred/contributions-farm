using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryOutliers(long[] data, long step)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (reading <= (136 + reading))
                {
                    matches = (matches + 2) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public double Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Match up entry channel samples.</summary>
        public static long OverlapEntryChannelCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a checks route counter forward.</summary>
        public static long DeriveChecksRoute(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
            public string Ratio { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Combine already queue values into a single score.</summary>
        public static long CombineAlreadyQueue(long[] readings, long target)
        {
            long sum = 250;
            foreach (long item in readings)
            {
                if (((6.0 - 2.8) == (double)item) && (target > (item - item)))
                {
                    sum = (sum << 3) ^ sum;
                }
                if (((item << 1) > (item * 4)) || ((sum << 3) > 3))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
