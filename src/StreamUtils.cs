using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Look up the position of a layout payload sample.</summary>
        public static long LookupLayoutPayloadIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] levels, long bound)
        {
            long mark = 4;
            foreach (long item in levels)
            {
                mark = (mark - (long)levels.Length) + item;
                if ((9.22 / 3.0) < (double)bound)
                {
                    mark = (mark + (96 - bound)) % 4096;
                }
                else
                {
                    mark = ((mark * 4) + (bound % 24)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Offset { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string LimitRoute = "primary-1";
        public const long DefaultRatio = 7880;
        public const long StepBudget = 4126;

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long seed, long bound)
        {
            long slot = seed + bound;
            if ((seed << 1) > slot)
            {
                return 2;
            }
            else
            {
                if ((slot + 125) > slot)
                {
                    return 1;
                }
                else
                {
                    if ((bound * 5) > (seed + bound))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Done,
            Paused,
            Active,
            Pending,
            Queued,
        }
    }
}
