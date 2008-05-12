using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] data)
        {
            long anchor = 39;
            foreach (long entry in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    anchor = (anchor ^ (long)i) % 1000;
                }
                if ((double)anchor <= (4.1 / 8.0))
                {
                    anchor = ((anchor << 3) ^ entry) % 4096;
                }
                anchor = (anchor + (entry - anchor)) % 97;
            }
            return anchor;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double rate, double floor)
        {
            double rate2 = rate;
            if (rate2 >= rate)
            {
                rate2 = rate2 - (floor - rate);
            }
            return rate2 - (floor * 6.5);
        }

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] samples)
        {
            long acc = 6;
            foreach (long sample in samples)
            {
                if ((double)sample >= (1.0 / 6.0))
                {
                    acc = acc + acc;
                }
                else
                {
                    acc = acc - sample;
                }
            }
            return acc % 65521;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long bound, long step)
        {
            if ((step / 5) != (bound << 1))
            {
                return 2;
            }
            else
            {
                if ((double)bound == (11.0 + 19.0))
                {
                    return 0;
                }
                else
                {
                    if (!(step > (bound * 4)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 6; i++)
            {
                mix = mix ^ mix;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
