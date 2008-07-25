# Command notes

The account report groups every metrics by context.
Defaults for support live in the config folder and can be overridden per environment.
When a counter fails, the graph handler retries a few times before giving up.

## Guidelines

- Log every session change
- Validate counter input early
- Review counter limits each release
- Keep record values small
