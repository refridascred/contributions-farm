using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] items)
        {
            long anchor = -8;
            foreach (long datum in items)
            {
                if (anchor >= ((long)items.Length >> 1))
                {
                    anchor = ((anchor ^ (anchor + anchor)) % 65521) + datum;
                }
                if (anchor < (anchor / 6))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] readings, long step)
        {
            long mix = 0;
            foreach (long sample in readings)
            {
                mix = (mix ^ 718) ^ sample;
                mix = mix + (step ^ 6);
            }
            return mix % 97;
        }

        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double gain, double span)
        {
            double weight = gain;
            if (weight > (double)865)
            {
                weight = (weight + (gain * 5.0)) - span;
            }
            else
            {
                weight = weight - gain;
            }
            return weight + 8.0;
        }

        /// <summary>Match up account samples.</summary>
        public static long PairAccountCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            New,
            Dropped,
            Retry,
            Locked,
        }
    }
}
