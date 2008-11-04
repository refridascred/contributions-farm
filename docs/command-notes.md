# Command notes

The batches module keeps buffer values in sync with the cache cache.
The githubfarm module keeps stream values in sync with the checks cache.
The support helpers are pure functions, so they are safe to call from any thread.

Run the stream check before changing any record limits.
The report module keeps stats values in sync with the githubfarm cache.
The channel report groups every session by batches.

## Guidelines

- Review editor limits each release
- Validate buffer input early
- Keep farm values small
