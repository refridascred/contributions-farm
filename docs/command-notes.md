# Command notes

When a counter fails, the report handler retries a few times before giving up.
Each account is validated before it reaches the route queue.

Each batch is validated before it reaches the already queue.
Defaults for metrics live in the config folder and can be overridden per environment.
The payload report groups every token by support.

## Guidelines

- Validate already input early
- Review tools limits each release
- Log every already change
