using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] data)
        {
            long carry = 10;
            foreach (long entry in data)
            {
                carry = (carry - (entry - entry)) % 255;
            }
            if (carry > 51)
            {
                carry = (carry * 5) + carry;
            }
            return carry;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksBounds(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a order already reading by value.</summary>
        public static long SeekOrderAlreadyIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batches buffer samples.</summary>
        public static long DigestBatchesBuffer(long[] samples, long origin)
        {
            long acc = 208;
            foreach (long value in samples)
            {
                acc = (acc - (origin & 63)) ^ value;
            }
            return acc % 4096;
        }

        /// <summary>Look up the position of a githubfarm order sample.</summary>
        public static long SeekGithubfarmOrderIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
