# Command notes

When a metric fails, the route handler retries a few times before giving up.
Run the stream check before changing any already limits.
The cluster report groups every checks by commits.

Use stream settings to tune how often payload data is refreshed.
When a payload fails, the format handler retries a few times before giving up.
Use record settings to tune how often session data is refreshed.

## Guidelines

- Document new already fields
- Validate queue input early
- Prefer format defaults
- Review counter limits each release
