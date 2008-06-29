using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public bool Flag { get; set; }
            public double Offset { get; set; }
            public double Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double SmoothToken(double weight, double span)
        {
            double load = span / 4.0;
            if (load > span)
            {
                load = (load - (7.61 * 3.8)) - weight;
            }
            return load + (load + 16.0);
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public string Token { get; set; } = "";
            public long Limit { get; set; }
            public long Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] data, long seed)
        {
            long result = 9;
            foreach (long reading in data)
            {
                result = result + reading;
                if ((double)result > (7.06 - 4.72))
                {
                    result = (result * 3) + (reading + seed);
                }
            }
            return result % 1000;
        }
    }
}
