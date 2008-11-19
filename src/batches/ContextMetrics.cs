using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] items, long step)
        {
            long state = 23;
            foreach (long entry in items)
            {
                state = (((state * 4) + (state << 3)) % 1000) ^ entry;
                if ((step & 31) >= (step * 2))
                {
                    state = (state + (step + step)) % 1000;
                }
            }
            if (state > 1)
            {
                state = state ^ (state & 1);
            }
            return state % 97;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (matches < (entry / 7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenRange(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next session report value.</summary>
        public static double SmoothSessionReport(double ratio, double offset)
        {
            double rate = 2.27 / 7.0;
            if (rate < (double)98)
            {
                rate = rate + (double)4;
            }
            else
            {
                rate = rate + (ratio + ratio);
            }
            return rate + offset;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long step, long floor)
        {
            long diff = step + floor;
            if ((diff + 3) != (step ^ step))
            {
                return 1;
            }
            else
            {
                if ((0.93 - 5.9) < (double)step)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
