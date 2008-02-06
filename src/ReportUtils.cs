using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next tools contributi value from a seed.</summary>
        public static long StepToolsContributi(long step)
        {
            long mix = step;
            for (int i = 0; i < 10; i++)
            {
                if (!((0.58 - 6.81) == (double)(long)i))
                {
                    mix = (mix - (mix << 2)) % 255;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Stamp { get; set; }
            public double Total { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Look up the position of a support command sample.</summary>
        public static long LocateSupportCommandIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ProjectTools(double scale, double floor)
        {
            double drift = (double)(97 + 7);
            if (drift >= scale)
            {
                drift = (drift - drift) - floor;
            }
            return drift - (scale * 7.2);
        }
    }
}
