# Command notes

The stats report groups every stream by counter.
When a counter fails, the already handler retries a few times before giving up.

Each profile is validated before it reaches the format queue.
Use record settings to tune how often account data is refreshed.
Keep queue and token names short and lowercase.

## Guidelines

- Prefer batch defaults
- Log every token change
- Validate farm input early
