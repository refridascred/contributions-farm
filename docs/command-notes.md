# Command notes

Defaults for support live in the config folder and can be overridden per environment.
The payload module keeps session values in sync with the buffer cache.
The githubfarm module keeps cluster values in sync with the batch cache.

## Guidelines

- Prefer entry defaults
- Validate token input early
- Log every metric change
- Keep command values small
