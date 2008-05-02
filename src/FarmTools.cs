using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next payload value.</summary>
        public static double ProjectPayload(double ratio, double offset)
        {
            double load = offset;
            if (load < (offset * 9.0))
            {
                load = (load - (offset - load)) - ratio;
            }
            else
            {
                load = load + load;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - offset) + (double)(long)i;
            }
            return load + (double)(-244);
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long offset, long offset2)
        {
            long delta = offset - offset2;
            if ((offset ^ offset2) >= (703 / 7))
            {
                return 8;
            }
            else
            {
                if (1.7 >= (double)offset2)
                {
                    return 2;
                }
                else
                {
                    if ((delta % 5) < 79)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((3 ^ 55) < offset2)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Count { get; set; }
            public double Mode { get; set; }
            public string Owner { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
