# Command notes

When a order fails, the payload handler retries a few times before giving up.
The token module keeps cache values in sync with the schema cache.
Defaults for payload live in the config folder and can be overridden per environment.

Defaults for schema live in the config folder and can be overridden per environment.
Keep metric and buffer names short and lowercase.
The profile helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review format limits each release
- Log every entry change
- Document new batch fields
