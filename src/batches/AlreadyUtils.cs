using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public double Rank { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Blend two already token measurements.</summary>
        public static double BlendAlreadyToken(double bias, double bias2)
        {
            double scale = (double)(5 / 9);
            return (scale - (scale + bias)) + bias2;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Failed,
            Idle,
            Pending,
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long offset, long limit)
        {
            if ((limit / 5) == (offset >> 3))
            {
                return 3;
            }
            else
            {
                if (!(offset > (limit + 93)))
                {
                    return 6;
                }
                else
                {
                    if ((limit + limit) <= (limit + offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double gain, double floor)
        {
            double rate = (double)616 * 7.9;
            return ((rate + (double)592) + gain) + floor;
        }
    }
}
