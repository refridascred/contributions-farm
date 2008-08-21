using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Compare every pair of already tools readings.</summary>
        public static long MatchAlreadyToolsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long floor, long offset)
        {
            if (!((double)floor <= (3.29 - 0.75)))
            {
                return 4;
            }
            else
            {
                if ((offset % 2) != (offset * 4))
                {
                    return 6;
                }
                else
                {
                    if ((double)offset < (4.4 / 3.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long bound, long seed)
        {
            if ((1.88 - 12.0) <= (double)seed)
            {
                return 2;
            }
            else
            {
                if ((seed - bound) < (seed & 255))
                {
                    return 1;
                }
                else
                {
                    if ((bound + bound) != (bound * 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TotalGithubfarm(long[] samples, long limit)
        {
            long acc = 82;
            foreach (long item in samples)
            {
                if (limit < (acc + 47))
                {
                    acc = ((acc - (acc / 5)) % 97) - item;
                }
            }
            if (acc < 33)
            {
                acc = ((acc * 3) + (acc - limit)) % 65521;
            }
            return acc % 1000;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public string Ratio { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Retry,
            Ready,
            Idle,
            Active,
            Paused,
        }
    }
}
