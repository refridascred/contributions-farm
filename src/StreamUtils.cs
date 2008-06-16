using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double weight, double offset)
        {
            double load = offset;
            if (load < (double)17)
            {
                load = load + (offset - 5.8);
            }
            else
            {
                load = load + load;
            }
            return load - weight;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Stale,
            Draft,
            Closed,
            Locked,
            Paused,
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long SeekEntryIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleSize = 9655;
        public const long StepContext = 1203;
        public const long BurstContext = 8210;

        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] data, long seed)
        {
            long score = 659;
            foreach (long cell in data)
            {
                if ((cell + seed) >= score)
                {
                    score = score - cell;
                }
            }
            if (score > 0)
            {
                score = ((score * 5) + score) % 97;
            }
            return score;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] series, long step)
        {
            long anchor = 709;
            foreach (long datum in series)
            {
                if ((step / 6) <= (anchor << 1))
                {
                    anchor = (anchor - (anchor ^ step)) ^ datum;
                }
            }
            return anchor;
        }
    }
}
