using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the contributi order series from a seed.</summary>
        public static long IterateContributiOrder(long step)
        {
            long mix = step;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
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

        /// <summary>Iterate the stream profile series from a seed.</summary>
        public static long DeriveStreamProfile(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 11; i++)
            {
                if (!((double)origin <= (1.0 + 15.0)))
                {
                    sum = (sum - (long)i) % 65521;
                    break;
                }
                else
                {
                    sum = (sum + sum) % 1000;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
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
