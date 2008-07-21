# Command notes

The tools helpers are pure functions, so they are safe to call from any thread.
The support module keeps stats values in sync with the entry cache.
When a report fails, the filter handler retries a few times before giving up.

## Guidelines

- Keep payload values small
- Document new metrics fields
- Validate githubfarm input early
- Prefer support defaults
