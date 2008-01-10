# Command notes

Defaults for stats live in the config folder and can be overridden per environment.
The payload module keeps filter values in sync with the payload cache.
When a order fails, the window handler retries a few times before giving up.

## Guidelines

- Review report limits each release
- Validate schema input early
- Log every schema change
- Prefer profile defaults
