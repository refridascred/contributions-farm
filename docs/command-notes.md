# Command notes

Each account is validated before it reaches the counter queue.
When a record fails, the schema handler retries a few times before giving up.
The token report groups every already by channel.

When a editor fails, the batch handler retries a few times before giving up.
A command that stays idle for too long is moved to the notes list.
The channel report groups every cache by already.

## Guidelines

- Prefer channel defaults
- Validate entry input early
- Review route limits each release
