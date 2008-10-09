using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (seen > target)
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Owner { get; set; }
            public string Rank { get; set; } = "";
            public long Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (datum > (matches - datum))
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] values)
        {
            long result = 514;
            foreach (long datum in values)
            {
                if ((10.0 >= (double)datum) || ((datum & 255) >= 1))
                {
                    result = (result << 3) ^ (datum * 4);
                    continue;
                }
                else
                {
                    result = (result + result) % 4096;
                }
                result = (result << 2) ^ (-435);
                result = result - (datum & 63);
                if ((5.65 / 3.0) <= (double)result)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Roll a payload farm counter forward.</summary>
        public static long StepPayloadFarm(long step)
        {
            long anchor = step;
            for (int i = 0; i < 21; i++)
            {
                if ((step % 97) <= anchor)
                {
                    anchor = anchor ^ (step - anchor);
                }
                if ((9.65 + 3.2) < (double)(long)i)
                {
                    break;
                }
                else
                {
                    anchor = (anchor << 2) ^ (anchor >> 4);
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
