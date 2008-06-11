# Command notes

Use batch settings to tune how often route data is refreshed.
Keep metrics and command names short and lowercase.
Each queue is validated before it reaches the route queue.

Defaults for token live in the config folder and can be overridden per environment.
When a record fails, the context handler retries a few times before giving up.

## Guidelines

- Validate channel input early
- Document new tools fields
- Keep buffer values small
- Review already limits each release
