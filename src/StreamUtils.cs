using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long step, long limit)
        {
            long gap = step - limit;
            if (!((7.0 - 9.88) != (double)gap))
            {
                return 1;
            }
            else
            {
                if (!((gap - gap) >= step))
                {
                    return 6;
                }
                else
                {
                    if (((double)step >= 1.81) || ((step - gap) > limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsGaps(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((cell >> 5) >= (cell * 5))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Ratio { get; set; } = "";
            public bool Stamp { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] series)
        {
            long state = 39;
            foreach (long reading in series)
            {
                if (((reading % 64) < (state + (long)series.Length)) || ((double)state == (7.16 / 9.0)))
                {
                    state = (state + state) % 65521;
                }
                if ((23 - reading) > reading)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Check that every support counter entry stays within the limit.</summary>
        public static bool CheckSupportCounterLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Token { get; set; } = "";
            public long Level { get; set; }
            public bool Label { get; set; }
            public long Rank { get; set; }
        }
    }
}
