# Command notes

The record module keeps cluster values in sync with the buffer cache.
The buffer helpers are pure functions, so they are safe to call from any thread.

When a buffer fails, the buffer handler retries a few times before giving up.
Keep account and tools names short and lowercase.
Defaults for payload live in the config folder and can be overridden per environment.

## Guidelines

- Prefer payload defaults
- Review schema limits each release
- Keep stats values small
- Log every already change
