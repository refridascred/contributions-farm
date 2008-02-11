# Command notes

When a payload fails, the batches handler retries a few times before giving up.
When a cluster fails, the schema handler retries a few times before giving up.

## Guidelines

- Keep payload values small
- Review channel limits each release
- Prefer account defaults
