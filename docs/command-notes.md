# Command notes

Defaults for notes live in the config folder and can be overridden per environment.
Defaults for schema live in the config folder and can be overridden per environment.
Run the command check before changing any channel limits.

Each session is validated before it reaches the tools queue.
When a checks fails, the filter handler retries a few times before giving up.

## Guidelines

- Validate farm input early
- Log every counter change
- Keep schema values small
- Prefer profile defaults
