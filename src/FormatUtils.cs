using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long floor, long step)
        {
            long delta = floor + step;
            if (((delta + delta) > (12 * 3)) && ((floor ^ 53) > (floor - step)))
            {
                return 8;
            }
            else
            {
                if ((step + floor) < delta)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Scale a notes batches figure with a bias.</summary>
        public static double BlendNotesBatches(double ratio, double bias)
        {
            double mean = ratio - (ratio + bias);
            if (mean > bias)
            {
                mean = mean + (double)9;
            }
            else
            {
                mean = mean - (ratio / 8.0);
            }
            return mean + (19.0 + 5.97);
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Label { get; set; }
            public long Token { get; set; }
            public long Flag { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Stamp { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Pending,
            New,
            Closed,
            Dropped,
        }

        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
