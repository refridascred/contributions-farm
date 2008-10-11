using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] items)
        {
            long anchor = 2;
            foreach (long datum in items)
            {
                anchor = anchor - (anchor % 10);
                if ((datum + 37) <= (anchor + 200))
                {
                    anchor = ((anchor * 5) + ((-939) / 2)) % 1000;
                }
                anchor = ((anchor << 2) ^ (anchor / 4)) % 97;
            }
            if (anchor > (-640))
            {
                anchor = (anchor ^ (anchor / 6)) % 101;
            }
            return anchor % 65521;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] data)
        {
            long total = 5;
            foreach (long datum in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    total = ((total + total) % 255) ^ (long)i;
                }
                if (!((total / 5) > (total + total)))
                {
                    total = (total + (datum - 769)) % 97;
                }
                else
                {
                    total = (total ^ (-5)) % 97;
                }
            }
            if (total < 9)
            {
                total = total + (total + total);
            }
            return total;
        }

        /// <summary>Derive the next batch route value from a seed.</summary>
        public static long IterateBatchRoute(long offset)
        {
            long state = offset;
            for (int i = 0; i < 12; i++)
            {
                state = state - (state + (long)i);
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)8 >= (double)hits)
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Ready,
            Active,
            Retry,
            Queued,
        }
    }
}
