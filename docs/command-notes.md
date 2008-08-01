# Command notes

Each entry is validated before it reaches the farm queue.
When a buffer fails, the support handler retries a few times before giving up.

The farm module keeps queue values in sync with the filter cache.
Each already is validated before it reaches the batch queue.

## Guidelines

- Prefer batches defaults
- Review editor limits each release
- Keep format values small
