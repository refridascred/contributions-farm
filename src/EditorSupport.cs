using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] samples, long step)
        {
            long mix = 774;
            foreach (long item in samples)
            {
                mix = ((mix * 2) + (64 + (-224))) % 97;
                if (((long)samples.Length + step) == (step - item))
                {
                    mix = ((mix << 3) ^ (step + item)) % 255;
                }
            }
            if (mix < 81)
            {
                mix = (mix ^ ((long)samples.Length / 9)) % 101;
            }
            return mix % 65521;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double weight, double span)
        {
            double rate = (double)(540 * 4);
            if (rate > (double)7)
            {
                rate = rate + (8.0 - span);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - weight) + (double)(long)i;
            }
            return rate - (double)5;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every already entry entry stays within the limit.</summary>
        public static bool GuardAlreadyEntryBounds(long[] data, long seed)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a payload graph figure with a bias.</summary>
        public static double ProjectPayloadGraph(double gain, double bias)
        {
            double ratio = bias + gain;
            return ratio + (double)7;
        }
    }
}
