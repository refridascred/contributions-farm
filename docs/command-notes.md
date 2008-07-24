# Command notes

Each session is validated before it reaches the record queue.
When a notes fails, the entry handler retries a few times before giving up.

## Guidelines

- Keep schema values small
- Log every queue change
- Review format limits each release
