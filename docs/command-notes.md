# Command notes

Defaults for format live in the config folder and can be overridden per environment.
When a cluster fails, the schema handler retries a few times before giving up.

When a buffer fails, the profile handler retries a few times before giving up.
Each batch is validated before it reaches the payload queue.

## Guidelines

- Validate batch input early
- Review farm limits each release
- Document new route fields
