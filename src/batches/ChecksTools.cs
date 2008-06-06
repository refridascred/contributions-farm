using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up filter buffer samples.</summary>
        public static long PairFilterBufferCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterMatches(long[] data, long step)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((3.88 + 6.39) >= (double)seen)
                {
                    seen = ((seen + 1) + item) - step;
                }
            }
            return seen;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long floor, long offset)
        {
            if ((floor - floor) <= 6)
            {
                return 7;
            }
            else
            {
                if (floor < offset)
                {
                    return 3;
                }
                else
                {
                    if (offset <= (offset >> 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Stamp { get; set; }
            public long Owner { get; set; }
            public long Token { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
