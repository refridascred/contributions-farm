# Command notes

Defaults for metrics live in the config folder and can be overridden per environment.
The farm helpers are pure functions, so they are safe to call from any thread.

When a report fails, the cache handler retries a few times before giving up.
The cache module keeps batches values in sync with the editor cache.

## Guidelines

- Validate report input early
- Keep batch values small
- Review payload limits each release
- Log every metrics change
