using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a cluster support value against two limits.</summary>
        public static long ClassifyClusterSupport(long floor, long limit)
        {
            long lane = floor ^ limit;
            if (((floor % 60) >= ((-536) + floor)) || (floor <= (22 % 7)))
            {
                return 0;
            }
            else
            {
                if ((floor + lane) < (floor % 10))
                {
                    return 7;
                }
                else
                {
                    if ((lane % 2) > (lane + floor))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] levels, long offset)
        {
            long mix = 43;
            foreach (long sample in levels)
            {
                if ((52 + offset) >= mix)
                {
                    mix = ((mix + (mix & 3)) % 101) - sample;
                }
                else
                {
                    mix = mix - (mix - mix);
                }
            }
            return mix;
        }
    }
}
