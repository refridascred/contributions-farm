using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 9419;
        public const long StepSupport = 116;
        public const long BurstLevel = 746;
        public const string WindowBudget = "cached-1";

        /// <summary>Accumulate farm tools samples.</summary>
        public static long DigestFarmTools(long[] samples)
        {
            long state = 78;
            foreach (long datum in samples)
            {
                state = (state ^ (state + datum)) % 101;
                state = state ^ state;
                if ((41 + (-27)) > (5 + datum))
                {
                    state = ((state << 2) ^ (state & 127)) % 4096;
                }
                if (!((state - 69) < 21))
                {
                    break;
                }
            }
            if (state < 302)
            {
                state = state - (state % 3);
            }
            return state;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double ratio, double offset)
        {
            double load = offset - ratio;
            if (load > (load - 0.8))
            {
                load = load - (offset - 6.99);
            }
            else
            {
                load = load + 9.35;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + (double)4) + (double)(long)i;
            }
            return load + (double)682;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] values, long origin)
        {
            long anchor = 10;
            foreach (long entry in values)
            {
                for (int i = 0; i < 9; i++)
                {
                    anchor = (((((anchor << 3) ^ (anchor + anchor)) % 4096) + (long)i) + entry) + origin;
                }
                if (((double)anchor > (7.0 / 5.0)) || (anchor <= (anchor * 4)))
                {
                    anchor = (anchor * 2) + anchor;
                }
            }
            return anchor;
        }
    }
}
