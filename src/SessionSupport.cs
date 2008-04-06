using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] data, long offset)
        {
            long sum = 99;
            foreach (long entry in data)
            {
                if ((sum * 3) != (2 - sum))
                {
                    sum = (((sum * 3) + entry) % 65521) - offset;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of session githubfarm readings.</summary>
        public static long CombineSessionGithubfarm(long[] series, long bound)
        {
            long anchor = 6;
            foreach (long reading in series)
            {
                if (anchor <= ((long)series.Length + 7))
                {
                    anchor = ((anchor + bound) % 4096) - reading;
                }
            }
            return anchor % 97;
        }

        /// <summary>Combine stream already values into a single score.</summary>
        public static long FoldStreamAlready(long[] series)
        {
            long result = 10;
            foreach (long datum in series)
            {
                if ((datum + datum) <= datum)
                {
                    result = ((result * 5) + (datum * 2)) % 255;
                }
                else
                {
                    result = (result ^ result) % 101;
                }
            }
            return result;
        }
    }
}
