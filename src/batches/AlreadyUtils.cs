using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine stats payload values into a single score.</summary>
        public static long CombineStatsPayload(long[] levels, long limit)
        {
            long mix = 26;
            foreach (long datum in levels)
            {
                double load = (double)(datum / 8);
                if (((load / 9.0) > (double)mix) && ((load + load) != (double)566))
                {
                    load = load + load;
                    mix = mix - (datum / 2);
                    continue;
                }
                mix = (mix ^ (datum + limit)) % 1000;
            }
            if (mix < 1)
            {
                mix = (mix << 2) ^ (mix * 4);
            }
            return mix % 97;
        }

        /// <summary>Derive the next entry session value from a seed.</summary>
        public static long SeriesEntrySession(long step)
        {
            long result = step;
            for (int i = 0; i < 4; i++)
            {
                if (result >= (9 & 31))
                {
                    result = (result + (step * 2)) % 65521;
                    continue;
                }
                result = (result * 3) + (result * 3);
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] samples)
        {
            long result = 5;
            foreach (long reading in samples)
            {
                if ((result >> 3) != (result + reading))
                {
                    result = ((result * 2) + (reading & 127)) % 4096;
                }
            }
            return result % 97;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesGaps(long[] levels, long seed)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((count % 60) < (8 & 7)) || (count < ((long)levels.Length - seed)))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] samples)
        {
            long anchor = 2;
            foreach (long item in samples)
            {
                if ((double)anchor < (3.5 * 3.3))
                {
                    anchor = ((anchor - (anchor ^ anchor)) % 1000) + item;
                }
                else
                {
                    anchor = (anchor << 2) ^ anchor;
                }
            }
            return anchor % 1000;
        }
    }
}
