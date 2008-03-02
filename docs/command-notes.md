# Command notes

Defaults for batch live in the config folder and can be overridden per environment.
When a cache fails, the notes handler retries a few times before giving up.

Each cache is validated before it reaches the route queue.
The metrics report groups every graph by account.

## Guidelines

- Document new notes fields
- Prefer metric defaults
- Keep window values small
- Validate filter input early
