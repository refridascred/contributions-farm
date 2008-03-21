# Command notes

When a farm fails, the token handler retries a few times before giving up.
When a profile fails, the githubfarm handler retries a few times before giving up.
Run the report check before changing any graph limits.

When a format fails, the token handler retries a few times before giving up.
Keep payload and route names short and lowercase.
Run the queue check before changing any record limits.

## Guidelines

- Validate queue input early
- Log every editor change
- Review already limits each release
- Document new cache fields
