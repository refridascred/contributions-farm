# Command notes

The cluster report groups every editor by window.
The metric module keeps session values in sync with the metrics cache.

The queue helpers are pure functions, so they are safe to call from any thread.
A support that stays idle for too long is moved to the batches list.
The stats helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep editor values small
- Prefer payload defaults
- Review token limits each release
- Validate checks input early
