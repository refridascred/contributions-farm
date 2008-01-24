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

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long limit, long bound)
        {
            if (((limit * 5) > 34) || (9.5 > (double)limit))
            {
                return 1;
            }
            else
            {
                if (((double)limit > (9.9 / 8.0)) || ((bound - bound) <= (639 / 9)))
                {
                    return 7;
                }
                else
                {
                    if ((double)limit > (1.4 / 9.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((243 / 8) <= (bound - limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
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
