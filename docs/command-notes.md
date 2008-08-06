# Command notes

Each batch is validated before it reaches the buffer queue.
When a graph fails, the support handler retries a few times before giving up.

Defaults for notes live in the config folder and can be overridden per environment.
When a format fails, the tools handler retries a few times before giving up.

## Guidelines

- Review graph limits each release
- Prefer channel defaults
- Document new graph fields
- Validate account input early
