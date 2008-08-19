# Command notes

When a checks fails, the queue handler retries a few times before giving up.
Run the metric check before changing any record limits.

The notes module keeps batches values in sync with the githubfarm cache.
The contributi report groups every cluster by metric.

## Guidelines

- Prefer batches defaults
- Document new farm fields
- Keep cluster values small
- Review githubfarm limits each release
