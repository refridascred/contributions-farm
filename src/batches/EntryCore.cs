using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricHits(long[] values, long seed)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (count < seed)
                {
                    count = (count + 3) - sample;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] readings, long target)
        {
            long mark = 3;
            foreach (long sample in readings)
            {
                mark = ((mark ^ (mark << 3)) % 1000) + sample;
                mark = (mark ^ target) % 1000;
            }
            if (mark < 857)
            {
                mark = (mark ^ (mark + 9)) % 65521;
            }
            return mark;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (!((reading <= (matches ^ matches)) || (((-2) + reading) > (matches * 2))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
