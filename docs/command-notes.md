# Command notes

Use command settings to tune how often report data is refreshed.
The stream report groups every format by cache.

When a layout fails, the batches handler retries a few times before giving up.
The notes helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate batch input early
- Review metrics limits each release
- Prefer already defaults
