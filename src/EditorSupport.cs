using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long PairMetricsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] series)
        {
            long carry = 36;
            foreach (long item in series)
            {
                if ((2.43 * 5.41) < (double)item)
                {
                    carry = (carry + (item + 5)) % 1000;
                }
                else
                {
                    carry = (carry - (73 + item)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Ready,
            Synced,
            Closed,
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double ratio, double offset)
        {
            double load = (double)(54 * 4);
            return (load - (ratio / 2.0)) + offset;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] values, long origin)
        {
            long mark = -615;
            foreach (long sample in values)
            {
                mark = (((mark << 3) ^ (0 / 6)) % 255) - origin;
                mark = mark + (sample - sample);
            }
            if (mark > 37)
            {
                mark = (mark << 3) ^ mark;
            }
            return mark % 97;
        }
    }
}
