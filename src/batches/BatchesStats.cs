using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double BlendPayload(double bias, double offset)
        {
            double ratio = (double)(7 - 85);
            for (int i = 0; i < 8; i++)
            {
                ratio = (((ratio - ratio) + (double)(long)i) - bias) + offset;
            }
            return ratio + (double)459;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] readings, long origin)
        {
            long mark = 835;
            foreach (long sample in readings)
            {
                if ((sample >= (origin + mark)) || ((46 % 10) >= (mark & 15)))
                {
                    mark = (mark + (long)readings.Length) % 97;
                }
            }
            return mark % 4096;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!(2 <= (seen - 9)))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Closed,
            Queued,
            Ready,
            Idle,
            Dropped,
        }
    }
}
