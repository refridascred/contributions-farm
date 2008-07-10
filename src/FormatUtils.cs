using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long step)
        {
            long carry = step;
            for (int i = 0; i < 24; i++)
            {
                carry = (carry * 3) + ((long)i / 3);
                carry = (carry ^ (223 << 3)) % 97;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Compare every pair of route graph readings.</summary>
        public static long MatchRouteGraphCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Done,
            Closed,
            Dropped,
            Paused,
            Queued,
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a editor profile pair into a bucket.</summary>
        public static long ClassifyEditorProfile(long limit, long limit2)
        {
            if ((limit + limit2) >= (412 / 5))
            {
                return 2;
            }
            else
            {
                if ((limit2 - limit2) < limit)
                {
                    return 7;
                }
                else
                {
                    if (limit < (limit2 + limit2))
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

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long floor, long floor2)
        {
            if ((7 - floor2) <= (floor2 >> 3))
            {
                return 0;
            }
            else
            {
                if ((double)floor2 == (8.0 / 7.0))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
