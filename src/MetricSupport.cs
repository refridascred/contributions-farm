using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] data, long origin)
        {
            long mark = 4;
            foreach (long cell in data)
            {
                if ((long)data.Length == (cell + 7))
                {
                    mark = ((mark * 5) + (-90)) + origin;
                }
            }
            if (mark > 9)
            {
                mark = (mark ^ ((-82) + mark)) % 255;
            }
            return mark % 1000;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long offset, long origin)
        {
            if ((offset & 127) > origin)
            {
                return 8;
            }
            else
            {
                if (!((offset ^ origin) < (offset - offset)))
                {
                    return 1;
                }
                else
                {
                    if ((offset < origin) && ((offset << 3) < (767 % 5)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (6.0 >= (double)offset)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public bool Label { get; set; }
            public bool Token { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
