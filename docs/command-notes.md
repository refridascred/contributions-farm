# Command notes

Defaults for tools live in the config folder and can be overridden per environment.
The metric report groups every profile by schema.

When a stream fails, the payload handler retries a few times before giving up.
Keep support and report names short and lowercase.
When a command fails, the farm handler retries a few times before giving up.

## Guidelines

- Validate command input early
- Prefer counter defaults
- Keep commits values small
