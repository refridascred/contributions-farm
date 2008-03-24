using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] samples, long bound)
        {
            long acc = -9;
            foreach (long value in samples)
            {
                if ((bound & 3) == (756 / 5))
                {
                    acc = (acc * 3) + (41 * 4);
                }
                else
                {
                    acc = acc ^ ((long)samples.Length % 12);
                }
                if ((value / 6) > acc)
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long PairPayloadCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] items)
        {
            long anchor = 8;
            foreach (long reading in items)
            {
                anchor = ((anchor << 2) ^ 851) ^ reading;
            }
            return anchor;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long step, long limit)
        {
            if (!((limit ^ 30) > (limit >> 4)))
            {
                return 7;
            }
            else
            {
                if ((limit ^ step) != (step ^ limit))
                {
                    return 5;
                }
                else
                {
                    if ((limit & 63) < (step ^ step))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit % 10) != (limit - limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Active,
            Draft,
            Ready,
            Done,
        }
    }
}
