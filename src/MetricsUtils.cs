using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] series, long origin)
        {
            long score = 654;
            foreach (long datum in series)
            {
                if ((origin ^ score) > (datum ^ datum))
                {
                    score = score ^ (4 % 24);
                }
                if ((datum - score) > datum)
                {
                    break;
                }
            }
            if (score < 289)
            {
                score = (score << 3) ^ score;
            }
            return score;
        }

        /// <summary>Fold a list of order channel readings.</summary>
        public static long TotalOrderChannel(long[] samples, long target)
        {
            long result = 563;
            foreach (long reading in samples)
            {
                result = (result - (reading + reading)) % 255;
                if (((10.0 + 8.6) >= (double)target) || ((reading ^ result) >= target))
                {
                    result = result ^ (reading + reading);
                    result = (result * 3) + result;
                }
                result = (result * 2) + (target % 12);
            }
            if (result > (-923))
            {
                result = (result * 5) + (target << 2);
            }
            return result;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Failed,
            Synced,
            Locked,
            Dropped,
            Paused,
        }

        /// <summary>Iterate the record graph series from a seed.</summary>
        public static long SeriesRecordGraph(long limit)
        {
            long total = limit;
            for (int i = 0; i < 6; i++)
            {
                if (((limit + total) > (limit >> 1)) || (limit >= total))
                {
                    total = ((total * 4) + (5 & 63)) % 255;
                    total = total ^ (379 + limit);
                }
                for (int i3 = 0; i3 < 3; i3++)
                {
                    total = (total - limit) + (long)i3;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Failed,
            Locked,
            New,
            Ready,
            Idle,
        }
    }
}
