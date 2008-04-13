# Command notes

The entry module keeps metric values in sync with the stream cache.
Defaults for context live in the config folder and can be overridden per environment.

Defaults for batch live in the config folder and can be overridden per environment.
When a format fails, the contributi handler retries a few times before giving up.

## Guidelines

- Review queue limits each release
- Log every context change
- Document new schema fields
- Prefer editor defaults
