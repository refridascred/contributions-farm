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

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell ^ cell) != (cell - cell))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
