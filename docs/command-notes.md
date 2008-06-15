# Command notes

Each channel is validated before it reaches the cache queue.
Keep report and report names short and lowercase.
Keep metric and metrics names short and lowercase.

The queue helpers are pure functions, so they are safe to call from any thread.
Run the filter check before changing any command limits.

## Guidelines

- Keep batches values small
- Prefer window defaults
- Document new context fields
- Review account limits each release
