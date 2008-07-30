# Command notes

The graph module keeps window values in sync with the filter cache.
The record report groups every metrics by session.

The commits report groups every context by format.
Each batches is validated before it reaches the batches queue.
The batches helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review record limits each release
- Prefer command defaults
- Keep contributi values small
