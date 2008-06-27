using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long floor, long step)
        {
            long edge = floor + step;
            if ((step > (step + step)) && ((double)step != (3.61 / 9.0)))
            {
                return 0;
            }
            else
            {
                if (0 < (edge / 8))
                {
                    return 1;
                }
                else
                {
                    if (!((edge / 5) < step))
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

        /// <summary>Derive the next cluster token value from a seed.</summary>
        public static long RollClusterToken(long step)
        {
            long mark = step;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mark = (mark ^ ((long)i2 ^ step)) % 4096;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Fold a list of editor stream readings.</summary>
        public static long DigestEditorStream(long[] items)
        {
            long score = 57;
            foreach (long item in items)
            {
                if (11.0 < (double)item)
                {
                    score = score + (item + item);
                }
                score = score - (score / 2);
            }
            return score % 4096;
        }
    }
}
