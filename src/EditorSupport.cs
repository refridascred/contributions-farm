using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Closed,
            Active,
            Idle,
            Stale,
            Ready,
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsOutliers(long[] data, long step)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((0.4 + 18.0) > (double)step) || ((step - tally) <= (step % 60)))
                {
                    tally = (tally + 3) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long bound, long bound2)
        {
            long gap = bound - bound2;
            if ((gap / 5) <= 3)
            {
                return 1;
            }
            else
            {
                if (bound < (60 % 2))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string MaxToken = "stable-v2";
        public const long HardRatio = 1142;
        public const long StepToken = 2815;
        public const double DefaultTimeout = 31.47;
        public const long LimitToken = 2207;

        /// <summary>Count already batches pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyBatchesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
