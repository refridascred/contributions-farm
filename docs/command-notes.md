# Command notes

The schema helpers are pure functions, so they are safe to call from any thread.
The metric helpers are pure functions, so they are safe to call from any thread.
The checks module keeps checks values in sync with the stream cache.

Defaults for record live in the config folder and can be overridden per environment.
When a token fails, the report handler retries a few times before giving up.

## Guidelines

- Log every already change
- Validate entry input early
- Prefer payload defaults
- Review editor limits each release
