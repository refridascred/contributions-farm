using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long step, long step2)
        {
            long delta = step ^ step2;
            if ((double)step2 > (double)step)
            {
                return 7;
            }
            else
            {
                if ((double)delta >= (3.62 / 4.0))
                {
                    return 8;
                }
                else
                {
                    if (step2 < (135 - delta))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseGraph = 8943;
        public const long SoftGraph = 6181;
        public const long HardGraph = 4777;
        public const long BatchWidth = 5628;
        public const double StepDepth = 15.82;

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Retry,
            Queued,
            Paused,
            Stale,
            New,
        }
    }
}
