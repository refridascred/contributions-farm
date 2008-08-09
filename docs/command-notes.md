# Command notes

The notes module keeps commits values in sync with the context cache.
The record module keeps schema values in sync with the counter cache.
A buffer that stays idle for too long is moved to the batches list.

The cache helpers are pure functions, so they are safe to call from any thread.
Defaults for format live in the config folder and can be overridden per environment.

## Guidelines

- Document new route fields
- Log every session change
- Prefer githubfarm defaults
- Validate checks input early
