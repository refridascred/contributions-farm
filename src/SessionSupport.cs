using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long offset, long target)
        {
            long offset2 = offset + target;
            if ((double)target > (7.3 + 4.6))
            {
                return 1;
            }
            else
            {
                if ((9.7 / 4.0) == (double)offset)
                {
                    return 8;
                }
                else
                {
                    if (!((offset - 55) >= offset2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Roll a batches commits counter forward.</summary>
        public static long SeriesBatchesCommits(long target)
        {
            long total = target;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Check that every support record entry stays within the limit.</summary>
        public static bool VerifySupportRecordLimits(long[] samples, long origin)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
