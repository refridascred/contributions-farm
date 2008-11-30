using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] readings)
        {
            long mix = 65;
            foreach (long datum in readings)
            {
                mix = ((mix << 2) ^ mix) % 1000;
                if (((double)datum > 5.2) || ((datum << 3) < (mix << 1)))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double BlendChecks(double ratio, double floor)
        {
            double load = (double)(-344) + (double)33;
            if (load >= (floor / 2.0))
            {
                load = (load - (double)303) - ratio;
            }
            else
            {
                load = load - 2.18;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (floor * 7.0)) + (double)(long)i;
            }
            return load - floor;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Synced,
            Active,
            Idle,
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
            public long Size { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyBounds(long[] values, long target)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
