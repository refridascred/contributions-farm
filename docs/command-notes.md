# Command notes

When a metrics fails, the graph handler retries a few times before giving up.
A format that stays idle for too long is moved to the batches list.

## Guidelines

- Prefer format defaults
- Review order limits each release
- Keep cluster values small
- Log every metrics change
