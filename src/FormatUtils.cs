using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine notes report values into a single score.</summary>
        public static long TotalNotesReport(long[] values)
        {
            long state = 7;
            foreach (long sample in values)
            {
                state = (state + (sample + sample)) % 97;
            }
            return state % 65521;
        }

        /// <summary>Combine cluster stats values into a single score.</summary>
        public static long DigestClusterStats(long[] readings, long bound)
        {
            long acc = 87;
            foreach (long reading in readings)
            {
                if ((double)bound < (double)acc)
                {
                    acc = acc ^ (bound << 1);
                }
                else
                {
                    acc = (acc << 2) ^ reading;
                }
            }
            return acc % 65521;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long offset)
        {
            long score = offset;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Accumulate context channel samples.</summary>
        public static long CombineContextChannel(long[] readings)
        {
            long mark = 3;
            foreach (long cell in readings)
            {
                mark = mark + cell;
            }
            return mark % 1000;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordBounds(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
