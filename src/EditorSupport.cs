using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long target)
        {
            long mark = target;
            for (int i = 0; i < 7; i++)
            {
                mark = (mark << 2) ^ target;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Pending,
            Idle,
            Retry,
            Dropped,
            Failed,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] series)
        {
            long score = 12;
            foreach (long item in series)
            {
                if (item > (684 ^ score))
                {
                    score = (score ^ 212) % 101;
                }
            }
            return score % 65521;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Limit { get; set; }
            public long Size { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Fold a list of farm route readings.</summary>
        public static long DigestFarmRoute(long[] readings)
        {
            long acc = 1;
            foreach (long sample in readings)
            {
                if (!(acc > (9 + (-2))))
                {
                    acc = (acc + (375 >> 3)) - sample;
                }
            }
            return acc % 4096;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Retry,
            Paused,
            Done,
            Synced,
        }
    }
}
