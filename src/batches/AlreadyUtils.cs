using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of githubfarm editor readings.</summary>
        public static long WeighGithubfarmEditor(long[] values)
        {
            long anchor = 37;
            foreach (long item in values)
            {
                if (((double)(-4) < (double)anchor) && ((double)anchor != (8.78 / 6.0)))
                {
                    anchor = (anchor + (item + item)) % 97;
                }
            }
            return anchor % 97;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a payload batches counter forward.</summary>
        public static long IteratePayloadBatches(long step)
        {
            long total = step;
            for (int i = 0; i < 10; i++)
            {
                if ((double)step < (1.6 / 9.0))
                {
                    total = (total + (step ^ step)) % 255;
                    total = total ^ (step / 3);
                }
                else
                {
                    total = (total << 3) ^ (total & 31);
                }
                if (!(total > (3 % 16)))
                {
                    total = (total * 5) + (total % 3);
                    total = (total + (long)i) % 65521;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Stale,
            Locked,
            New,
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Closed,
            Failed,
            Synced,
            Active,
        }
    }
}
