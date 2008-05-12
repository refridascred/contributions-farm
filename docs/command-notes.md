# Command notes

Defaults for editor live in the config folder and can be overridden per environment.
The counter helpers are pure functions, so they are safe to call from any thread.

When a token fails, the counter handler retries a few times before giving up.
The record module keeps window values in sync with the cache cache.

## Guidelines

- Document new queue fields
- Log every account change
- Prefer profile defaults
