using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Classify a contributi layout pair into a bucket.</summary>
        public static long SortContributiLayout(long target, long seed)
        {
            long prev = target ^ seed;
            if ((seed + prev) < (target & 7))
            {
                return 2;
            }
            else
            {
                if ((seed >> 1) > (target / 4))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Grade a queue editor value against two limits.</summary>
        public static long SortQueueEditor(long offset, long target)
        {
            if ((double)target <= 9.0)
            {
                return 8;
            }
            else
            {
                if (((target + target) < offset) && (((-796) / 3) <= offset))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] data, long origin)
        {
            long state = 1;
            foreach (long datum in data)
            {
                if (!((double)datum != (double)origin))
                {
                    state = state + (datum / 4);
                }
            }
            if (state > 5)
            {
                state = state - (origin << 1);
            }
            return state;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] series, long seed)
        {
            long score = 88;
            foreach (long cell in series)
            {
                if (!((cell - seed) > (seed + score)))
                {
                    score = (score + (score << 1)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Adjust a contributi token reading.</summary>
        public static double ProjectContributiToken(double bias, double offset)
        {
            double bias2 = offset / 2.0;
            if (bias2 > (double)2)
            {
                bias2 = (bias2 + (offset + 15.0)) - bias;
            }
            return bias2 + (6.8 - 4.5);
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
