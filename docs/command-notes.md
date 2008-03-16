# Command notes

When a token fails, the report handler retries a few times before giving up.
A metrics that stays idle for too long is moved to the metrics list.
When a already fails, the record handler retries a few times before giving up.

## Guidelines

- Document new window fields
- Log every report change
- Review already limits each release
- Prefer format defaults
