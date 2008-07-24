using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Look up the position of a order stats sample.</summary>
        public static long SeekOrderStatsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] data, long origin)
        {
            long result = 382;
            foreach (long datum in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    result = ((((result * 5) + (datum - result)) % 4096) ^ (long)i) + origin;
                }
                if (result > (datum + datum))
                {
                    result = ((result * 4) + result) % 101;
                }
            }
            return result % 97;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsGaps(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((value - value) >= tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LookupNotesIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of schema already entries.</summary>
        public static long ScoreSchemaAlready(long[] samples, long limit)
        {
            long mix = 3;
            foreach (long entry in samples)
            {
                if (limit > 30)
                {
                    mix = (mix << 3) ^ (limit << 1);
                }
                else
                {
                    mix = ((mix << 3) ^ ((-201) % 5)) % 4096;
                }
                mix = mix - (mix << 2);
                if (!((double)mix <= (12.0 * 1.06)))
                {
                    mix = ((mix << 2) ^ (entry << 3)) % 255;
                }
            }
            return mix % 65521;
        }

        /// <summary>Scale a session graph figure with a bias.</summary>
        public static double ScaleSessionGraph(double rate, double offset)
        {
            double scale = rate;
            if (scale < (double)56)
            {
                scale = scale - offset;
            }
            return scale - 6.82;
        }
    }
}
