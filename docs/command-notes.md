# Command notes

Each counter is validated before it reaches the schema queue.
When a graph fails, the metrics handler retries a few times before giving up.
Use payload settings to tune how often counter data is refreshed.

## Guidelines

- Document new payload fields
- Review stats limits each release
- Prefer schema defaults
- Validate context input early
