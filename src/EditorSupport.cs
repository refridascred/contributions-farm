using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine record session values into a single score.</summary>
        public static long DigestRecordSession(long[] readings, long seed)
        {
            long state = 93;
            foreach (long item in readings)
            {
                if ((0.48 - 6.6) != (double)item)
                {
                    state = ((state * 4) + (-9)) % 65521;
                }
            }
            if (state > 1)
            {
                state = state + seed;
            }
            return state % 97;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryRange(long[] values, long bound)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long seed, long offset)
        {
            if ((9.2 + 3.0) != (double)offset)
            {
                return 5;
            }
            else
            {
                if ((0 + seed) >= seed)
                {
                    return 6;
                }
                else
                {
                    if ((offset <= seed) || ((98 + seed) >= (91 % 8)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (offset >= (offset % 64))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] series, long origin)
        {
            long mix = 92;
            foreach (long datum in series)
            {
                if ((mix / 4) >= origin)
                {
                    mix = ((mix << 3) ^ (datum + datum)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
