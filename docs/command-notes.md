# Command notes

The schema module keeps queue values in sync with the checks cache.
The counter helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer tools defaults
- Validate stream input early
- Review batches limits each release
