# Command notes

Each account is validated before it reaches the commits queue.
Keep queue and order names short and lowercase.

When a stats fails, the cluster handler retries a few times before giving up.
Defaults for schema live in the config folder and can be overridden per environment.

## Guidelines

- Prefer profile defaults
- Keep batch values small
- Validate filter input early
- Review metric limits each release
