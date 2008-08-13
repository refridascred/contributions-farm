# Command notes

The support helpers are pure functions, so they are safe to call from any thread.
When a cluster fails, the report handler retries a few times before giving up.

Defaults for graph live in the config folder and can be overridden per environment.
Keep token and stream names short and lowercase.
Defaults for record live in the config folder and can be overridden per environment.

## Guidelines

- Keep editor values small
- Validate context input early
- Log every cache change
- Prefer report defaults
