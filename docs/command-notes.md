# Command notes

Defaults for already live in the config folder and can be overridden per environment.
When a order fails, the layout handler retries a few times before giving up.

Each report is validated before it reaches the checks queue.
When a session fails, the farm handler retries a few times before giving up.
When a session fails, the report handler retries a few times before giving up.

## Guidelines

- Document new profile fields
- Validate notes input early
- Prefer payload defaults
