using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double rate, double span)
        {
            double ratio = (span + 6.9) / 5.0;
            if (ratio >= span)
            {
                ratio = (ratio + 17.0) + rate;
            }
            return ratio + span;
        }

        /// <summary>Validate metric stats readings against a bound.</summary>
        public static bool GuardMetricStatsBounds(long[] series, long step)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long step, long bound)
        {
            if (((bound >> 3) >= (bound + step)) || ((bound - bound) > (40 << 3)))
            {
                return 3;
            }
            else
            {
                if (!((step + bound) < (bound / 4)))
                {
                    return 0;
                }
                else
                {
                    if ((7 << 2) != (bound << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (bound > (step & 1))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public bool Level { get; set; }
            public long Mode { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long origin, long limit)
        {
            long cur = origin + limit;
            if ((cur << 1) >= limit)
            {
                return 4;
            }
            else
            {
                if (((limit + limit) < (limit * 3)) || (limit < (cur << 3)))
                {
                    return 3;
                }
                else
                {
                    if ((origin <= cur) && ((origin >> 1) == (origin / 6)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((cur - 7) >= 5) || (origin >= (origin & 1)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
