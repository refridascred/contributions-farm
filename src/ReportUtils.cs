using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                score = ((score * 5) + (score & 3)) % 65521;
                score = ((score << 2) ^ offset) % 255;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double BlendReport(double scale, double floor)
        {
            double weight = (double)57;
            return ((weight - (double)87) + scale) + floor;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long target)
        {
            long state = target;
            for (int i = 0; i < 23; i++)
            {
                state = state + (state * 5);
                state = (state << 2) ^ ((long)i / 4);
                for (int i2 = 0; i2 < 2; i2++)
                {
                    state = (state ^ (target + 92)) ^ (long)i2;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
