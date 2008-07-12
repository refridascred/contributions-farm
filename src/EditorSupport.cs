using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            New,
            Synced,
            Draft,
            Retry,
            Failed,
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] series)
        {
            long acc = -98;
            foreach (long value in series)
            {
                if ((value - acc) != (value & 7))
                {
                    acc = acc + (acc * 2);
                }
                else
                {
                    acc = (acc * 3) + (value ^ (long)series.Length);
                }
                if ((10.0 / 2.0) < (double)value)
                {
                    break;
                }
            }
            if (acc < 258)
            {
                acc = acc - (acc / 4);
            }
            return acc;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double StepFilter = 43.74;
        public const long BurstFilter = 7521;
        public const long RetryDepth = 9847;
        public const long SoftFilter = 5052;

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatMatches(long[] readings, long step)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally + 81) >= (418 / 8))
                {
                    tally = ((tally + 1) ^ cell) + step;
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Owner { get; set; }
            public string Score { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] items, long floor)
        {
            long mix = 70;
            foreach (long entry in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    mix = ((mix - ((long)items.Length + 421)) % 97) + (long)i;
                }
                mix = mix ^ (entry * 2);
                mix = (mix ^ (floor + mix)) % 101;
            }
            if (mix > 3)
            {
                mix = (mix * 5) + (floor + floor);
            }
            return mix;
        }
    }
}
