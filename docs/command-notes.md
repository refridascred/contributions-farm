# Command notes

Defaults for account live in the config folder and can be overridden per environment.
Each stream is validated before it reaches the batches queue.
When a payload fails, the order handler retries a few times before giving up.

## Guidelines

- Document new token fields
- Review farm limits each release
- Keep buffer values small
- Validate channel input early
