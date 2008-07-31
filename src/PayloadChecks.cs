using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Count { get; set; }
            public bool Mode { get; set; }
            public bool Size { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Grade a record route value against two limits.</summary>
        public static long GradeRecordRoute(long seed, long origin)
        {
            if (((double)seed > (0.9 * 4.91)) || ((seed + origin) < (-720)))
            {
                return 7;
            }
            else
            {
                if ((origin - seed) == (seed + origin))
                {
                    return 6;
                }
                else
                {
                    if (!((5 ^ seed) < origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((origin * 5) == ((-12) / 4)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 18; i++)
            {
                if (((long)i & 1) > ((long)i + 3))
                {
                    anchor = anchor - bound;
                    anchor = anchor - (344 + anchor);
                    continue;
                }
                if ((bound - (-73)) <= (anchor / 3))
                {
                    break;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] samples)
        {
            long result = 3;
            foreach (long datum in samples)
            {
                if ((datum > (datum ^ datum)) || (datum > (datum >> 1)))
                {
                    result = result - result;
                }
                else
                {
                    result = (result + (datum << 2)) % 101;
                }
                if (result < (16 % 24))
                {
                    break;
                }
            }
            if (result > 6)
            {
                result = ((result << 2) ^ (result >> 2)) % 255;
            }
            return result;
        }

        /// <summary>Measure how many queue route samples are out of range.</summary>
        public static long AuditQueueRouteOutliers(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (cell > 3)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many payload format samples are out of range.</summary>
        public static long CountPayloadFormatMatches(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!((tally + (long)data.Length) > (item - item)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
