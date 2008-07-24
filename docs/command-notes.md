# Command notes

The format module keeps record values in sync with the filter cache.
The layout report groups every metric by payload.
Keep record and payload names short and lowercase.

Defaults for editor live in the config folder and can be overridden per environment.
A counter that stays idle for too long is moved to the record list.
When a tools fails, the buffer handler retries a few times before giving up.

## Guidelines

- Log every already change
- Keep channel values small
- Validate session input early
