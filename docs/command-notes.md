# Command notes

Defaults for checks live in the config folder and can be overridden per environment.
When a buffer fails, the batches handler retries a few times before giving up.
When a stats fails, the notes handler retries a few times before giving up.

## Guidelines

- Log every window change
- Keep account values small
- Prefer token defaults
- Review metrics limits each release
