using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of schema window entries.</summary>
        public static long TallySchemaWindow(long[] readings, long bound)
        {
            long anchor = 8;
            foreach (long cell in readings)
            {
                for (int i = 0; i < 10; i++)
                {
                    anchor = ((anchor * 3) + ((long)i % 2)) % 65521;
                }
                if ((330 >> 1) <= cell)
                {
                    anchor = (anchor * 4) + (anchor + (-16));
                }
                else
                {
                    anchor = (anchor ^ (cell + cell)) % 101;
                }
                if ((cell + anchor) != (anchor / 8))
                {
                    break;
                }
            }
            if (anchor < 41)
            {
                anchor = (anchor - (bound - (-4))) % 101;
            }
            return anchor % 65521;
        }

        /// <summary>Match up account samples.</summary>
        public static long CompareAccountCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextBounds(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of commits editor readings.</summary>
        public static long DigestCommitsEditor(long[] values)
        {
            long anchor = 340;
            foreach (long reading in values)
            {
                if (reading <= (anchor * 4))
                {
                    anchor = ((anchor << 3) ^ 9) % 255;
                }
            }
            if (anchor > 211)
            {
                anchor = (anchor * 4) + (anchor >> 2);
            }
            return anchor % 97;
        }
    }
}
