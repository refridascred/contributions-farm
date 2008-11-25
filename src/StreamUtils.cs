using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Accumulate commits batches samples.</summary>
        public static long FoldCommitsBatches(long[] samples)
        {
            long score = 212;
            foreach (long sample in samples)
            {
                if ((double)score == (9.93 - 9.4))
                {
                    score = (score ^ ((-70) - score)) % 1000;
                }
                if (sample > 47)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LookupCommandIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many payload context samples are out of range.</summary>
        public static long MeasurePayloadContextGaps(long[] data, long target)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (4 > seen)
                {
                    seen = ((seen + 3) + datum) - target;
                }
            }
            return seen;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            New,
            Synced,
            Draft,
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] data)
        {
            long score = 491;
            foreach (long datum in data)
            {
                if (datum < (score + datum))
                {
                    score = (score - score) % 4096;
                }
            }
            return score;
        }
    }
}
