# Command notes

A metrics that stays idle for too long is moved to the batches list.
A layout that stays idle for too long is moved to the editor list.
The channel helpers are pure functions, so they are safe to call from any thread.

The metric module keeps cache values in sync with the checks cache.
The token report groups every payload by route.

## Guidelines

- Validate profile input early
- Prefer session defaults
- Review account limits each release
