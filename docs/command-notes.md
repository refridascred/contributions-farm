# Command notes

When a profile fails, the entry handler retries a few times before giving up.
Each format is validated before it reaches the tools queue.

## Guidelines

- Prefer counter defaults
- Log every graph change
- Validate buffer input early
