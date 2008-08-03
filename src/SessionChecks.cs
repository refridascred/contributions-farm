using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count contributi account pairs that satisfy a relation.</summary>
        public static long MatchContributiAccountCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many stream token samples are out of range.</summary>
        public static long CountStreamTokenOutliers(long[] data, long step)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!((cell + step) > (cell << 3)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] levels, long floor)
        {
            long mark = 34;
            foreach (long value in levels)
            {
                if (floor <= (value % 64))
                {
                    mark = (mark + mark) % 255;
                }
                else
                {
                    mark = ((mark * 2) + floor) % 255;
                }
            }
            if (mark > 53)
            {
                mark = (mark + floor) % 65521;
            }
            return mark;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] samples, long bound)
        {
            long result = 25;
            foreach (long sample in samples)
            {
                if ((88 / 2) < ((long)samples.Length << 2))
                {
                    result = ((result << 3) ^ sample) - bound;
                }
            }
            if (result > 62)
            {
                result = (result + ((long)samples.Length / 4)) % 4096;
            }
            return result % 4096;
        }
    }
}
