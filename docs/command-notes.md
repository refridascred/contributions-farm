# Command notes

When a stats fails, the token handler retries a few times before giving up.
Run the tools check before changing any context limits.

Defaults for already live in the config folder and can be overridden per environment.
Run the schema check before changing any stream limits.
Each account is validated before it reaches the token queue.

## Guidelines

- Review format limits each release
- Validate channel input early
- Prefer farm defaults
