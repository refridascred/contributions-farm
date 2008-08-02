# Command notes

Keep checks and tools names short and lowercase.
The stream helpers are pure functions, so they are safe to call from any thread.

When a commits fails, the checks handler retries a few times before giving up.
Use cluster settings to tune how often farm data is refreshed.
The token module keeps tools values in sync with the counter cache.

## Guidelines

- Document new metrics fields
- Validate payload input early
- Prefer profile defaults
