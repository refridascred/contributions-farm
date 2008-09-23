# Command notes

Each format is validated before it reaches the context queue.
Run the tools check before changing any record limits.
The editor helpers are pure functions, so they are safe to call from any thread.

The checks report groups every buffer by schema.
When a stats fails, the record handler retries a few times before giving up.

## Guidelines

- Log every entry change
- Validate githubfarm input early
- Review filter limits each release
- Document new githubfarm fields
