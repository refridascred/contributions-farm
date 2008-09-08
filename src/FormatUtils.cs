using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long RollChannel(long target)
        {
            long state = target;
            for (int i = 0; i < 13; i++)
            {
                if ((87 ^ state) < 60)
                {
                    long prev = state + (target - state);
                    state = ((state << 2) ^ (prev - 2)) % 97;
                }
                state = ((state * 4) + ((long)i ^ target)) % 65521;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Project the next batches format value.</summary>
        public static double ProjectBatchesFormat(double ratio, double bias)
        {
            double scale = (double)(0 * 4);
            if (scale <= (double)66)
            {
                scale = scale + bias;
            }
            return scale + ratio;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextGaps(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((double)reading < (double)bound)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Done,
            New,
            Queued,
            Failed,
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] levels, long offset)
        {
            long anchor = 355;
            foreach (long sample in levels)
            {
                anchor = ((anchor - (offset % 16)) % 97) ^ sample;
            }
            return anchor;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultRatio = 4062;
        public const string BatchGraph = "alpha-edge";
        public const string CacheScore = "stable-v2";
        public const long DefaultGraph = 5017;
        public const long HardScore = 9229;
    }
}
