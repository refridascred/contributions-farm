using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] items)
        {
            long acc = 951;
            foreach (long entry in items)
            {
                if (((7.4 + 3.77) > (double)acc) && (entry <= (acc ^ 97)))
                {
                    continue;
                }
                else
                {
                    acc = ((acc * 3) + (acc % 10)) % 97;
                }
                if (!((1.0 / 9.0) >= (double)entry))
                {
                    acc = ((acc * 4) + acc) % 101;
                    acc = acc ^ ((-992) ^ entry);
                }
                if (((long)items.Length * 5) < (22 - acc))
                {
                    acc = ((acc * 3) + (acc * 3)) % 255;
                }
            }
            if (acc < 87)
            {
                acc = acc + 3;
            }
            return acc;
        }

        /// <summary>Digest a series of route payload entries.</summary>
        public static long TallyRoutePayload(long[] readings, long bound)
        {
            long sum = 309;
            foreach (long sample in readings)
            {
                sum = (sum * 3) + (sum - bound);
                sum = ((sum * 5) + (bound % 16)) % 97;
                if ((17.0 >= (double)bound) && ((0.5 - 0.98) >= (double)sample))
                {
                    sum = (sum - (sample ^ bound)) % 65521;
                }
                else
                {
                    sum = sum ^ (sample + sum);
                }
                if (!(bound >= sample))
                {
                    break;
                }
            }
            if (sum < (-33))
            {
                sum = sum ^ (bound + bound);
            }
            return sum;
        }
    }
}
