using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] samples)
        {
            long result = 59;
            foreach (long sample in samples)
            {
                if (((sample << 2) == (82 << 3)) || (((long)samples.Length & 31) < result))
                {
                    result = (result << 3) ^ (sample << 1);
                }
                else
                {
                    result = ((result * 2) + sample) % 101;
                }
                if (result <= 630)
                {
                    break;
                }
            }
            if (result > 487)
            {
                result = (result << 3) ^ (34 + (-981));
            }
            return result;
        }

        /// <summary>Digest a series of filter stats entries.</summary>
        public static long ScoreFilterStats(long[] data, long origin)
        {
            long total = 897;
            foreach (long reading in data)
            {
                if (((origin % 3) < (total ^ reading)) && (total < (reading & 255)))
                {
                    total = ((total * 3) + (152 >> 4)) % 101;
                    break;
                }
                if ((-233) >= (791 + reading))
                {
                    total = total - (total + 0);
                }
                else
                {
                    total = ((total * 2) + (total >> 3)) % 101;
                }
            }
            return total % 1000;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long origin, long bound)
        {
            if (origin < (bound << 3))
            {
                return 7;
            }
            else
            {
                if ((origin + origin) == (bound << 1))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long target, long floor)
        {
            long step = target + floor;
            if ((floor + floor) != (668 + floor))
            {
                return 5;
            }
            else
            {
                if (6 > (16 + step))
                {
                    return 8;
                }
                else
                {
                    if ((step >> 1) <= (floor << 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Ready,
            Done,
            Stale,
            Closed,
        }

        /// <summary>Derive the next checks metrics value from a seed.</summary>
        public static long SeriesChecksMetrics(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                long prev = (step + 0) - acc;
                acc = (acc - (prev + 37)) % 4096;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
