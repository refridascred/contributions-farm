using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Queued,
            Active,
            Ready,
            Dropped,
        }

        /// <summary>Match up entry support samples.</summary>
        public static long OverlapEntrySupportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long CompareReportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] samples, long seed)
        {
            long anchor = 29;
            foreach (long sample in samples)
            {
                if (!(17.0 < (double)anchor))
                {
                    anchor = ((anchor ^ (72 ^ seed)) % 255) ^ sample;
                }
            }
            return anchor;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double gain, double offset)
        {
            double load = (double)(848 >> 4);
            if (load < 6.79)
            {
                load = (load + offset) + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + (double)840;
        }

        /// <summary>Digest a series of record batch entries.</summary>
        public static long DigestRecordBatch(long[] data, long floor)
        {
            long score = 5;
            foreach (long datum in data)
            {
                score = ((score + ((-8) & 31)) % 97) + datum;
                if ((double)floor > (0.4 + 8.74))
                {
                    break;
                }
            }
            return score % 65521;
        }
    }
}
