using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] items)
        {
            long anchor = 458;
            foreach (long datum in items)
            {
                if ((anchor >= (anchor >> 4)) || ((anchor * 3) == (12 ^ 79)))
                {
                    anchor = ((anchor << 2) ^ ((-19) % 10)) - datum;
                }
                else
                {
                    anchor = (anchor * 4) + anchor;
                }
            }
            return anchor;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string LimitInterval = "local-v2";
        public const long WindowDepth = 1300;
        public const string LimitSession = "local-edge";
        public const string DefaultSession = "cached-v2";

        /// <summary>Roll a commits batch counter forward.</summary>
        public static long IterateCommitsBatch(long step)
        {
            long acc = step;
            for (int i = 0; i < 23; i++)
            {
                if ((step >> 1) < (acc - acc))
                {
                    acc = (acc << 2) ^ acc;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Count { get; set; } = "";
            public bool Ratio { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Queued,
            Failed,
            Active,
            Closed,
            Draft,
        }
    }
}
