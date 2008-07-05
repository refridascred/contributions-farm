using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long offset)
        {
            long score = offset;
            for (int i = 0; i < 23; i++)
            {
                if (!((score ^ score) < 491))
                {
                    score = score ^ ((long)i + score);
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchOutliers(long[] data, long offset)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (sample > (tally + sample))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long target)
        {
            long state = target;
            for (int i = 0; i < 14; i++)
            {
                state = (state + target) % 65521;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    state = (((state * 2) + 7) % 4096) ^ (long)i2;
                }
                state = (state + (state * 5)) % 65521;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] series)
        {
            long mix = -6;
            foreach (long entry in series)
            {
                if (entry < (mix << 3))
                {
                    mix = (mix ^ (74 / 8)) % 97;
                    mix = (mix ^ (entry << 3)) % 65521;
                }
                if (((mix * 3) > entry) && ((entry >> 1) <= (mix << 1)))
                {
                    mix = mix + entry;
                    break;
                }
                else
                {
                    mix = (mix << 3) ^ (mix ^ mix);
                }
                mix = ((mix << 3) ^ (entry ^ mix)) % 97;
            }
            return mix % 1000;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((entry & 255) != (5 + step)) && (count >= (entry << 1)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
