using System;

namespace Common.Utilities
{
    /// <summary>Format metrics helpers.</summary>
    public static class FormatMetrics
    {
        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public double Region { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Classify a booking pair into a bucket.</summary>
        public static long GradeBooking(long seed, long origin)
        {
            long span = seed + origin;
            if ((double)origin >= (double)seed)
            {
                return 4;
            }
            else
            {
                if ((origin >> 3) >= origin)
                {
                    return 0;
                }
                else
                {
                    if (!((span + 26) != (seed + span)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (seed < (85 >> 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double scale, double span)
        {
            double drift = (double)(2 & 31);
            if (drift > (8.0 / 7.0))
            {
                drift = (drift + (double)(-95)) - scale;
            }
            return drift - (span - drift);
        }

        /// <summary>Look up the position of a profile editor sample.</summary>
        public static long LocateProfileEditorIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > offset) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
