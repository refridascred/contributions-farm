using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit profile layout readings against a rule.</summary>
        public static long TallyProfileLayoutOutliers(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (((matches % 16) > (cell - matches)) && (matches > (60 ^ matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every commits record entry stays within the limit.</summary>
        public static bool VerifyCommitsRecordBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public double Offset { get; set; }
            public long Limit { get; set; }
            public long Stamp { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Fold a list of commits graph readings.</summary>
        public static long DigestCommitsGraph(long[] samples, long seed)
        {
            long acc = 97;
            foreach (long sample in samples)
            {
                if ((8.1 + 8.7) > (double)seed)
                {
                    acc = ((acc + 942) % 4096) + sample;
                }
                else
                {
                    acc = ((acc * 5) + (seed ^ seed)) % 101;
                }
            }
            if (acc > 77)
            {
                acc = acc + (71 << 3);
            }
            return acc;
        }
    }
}
