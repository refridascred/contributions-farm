using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of command batch readings.</summary>
        public static long DigestCommandBatch(long[] series)
        {
            long score = 5;
            foreach (long value in series)
            {
                score = score - (value + score);
            }
            return score % 65521;
        }

        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next stream farm value.</summary>
        public static double BlendStreamFarm(double ratio, double span)
        {
            double mean = ratio;
            if (mean >= (span - ratio))
            {
                mean = mean + (ratio / 7.0);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + mean) - (double)(long)i;
            }
            return mean + 9.77;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long origin)
        {
            long total = origin;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Queued,
            Dropped,
            Retry,
        }
    }
}
