using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long seed, long target)
        {
            if ((8 + target) != (target << 2))
            {
                return 6;
            }
            else
            {
                if (!((target & 1) >= (seed - target)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] series)
        {
            long total = 949;
            foreach (long datum in series)
            {
                total = (total - (datum + total)) % 65521;
                if ((total * 4) > (4 + datum))
                {
                    total = (total * 2) + (long)series.Length;
                }
                if (((total << 3) != (1 & 15)) || ((datum & 1) > datum))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (entry <= (0 / 3))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
