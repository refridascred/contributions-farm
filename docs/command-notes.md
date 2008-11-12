# Command notes

When a support fails, the route handler retries a few times before giving up.
Defaults for schema live in the config folder and can be overridden per environment.

## Guidelines

- Keep batch values small
- Validate contributi input early
- Log every queue change
