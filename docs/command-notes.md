# Command notes

A stats that stays idle for too long is moved to the report list.
A report that stays idle for too long is moved to the account list.
Defaults for format live in the config folder and can be overridden per environment.

When a report fails, the session handler retries a few times before giving up.
Run the stats check before changing any queue limits.
Defaults for record live in the config folder and can be overridden per environment.

## Guidelines

- Keep layout values small
- Prefer session defaults
- Document new commits fields
- Validate entry input early
