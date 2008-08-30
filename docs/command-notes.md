# Command notes

A metrics that stays idle for too long is moved to the batches list.
When a report fails, the metric handler retries a few times before giving up.
Keep filter and entry names short and lowercase.

## Guidelines

- Prefer stream defaults
- Validate batches input early
- Review graph limits each release
- Document new schema fields
