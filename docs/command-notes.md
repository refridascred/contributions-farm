# Command notes

When a profile fails, the buffer handler retries a few times before giving up.
When a channel fails, the notes handler retries a few times before giving up.

## Guidelines

- Keep queue values small
- Validate filter input early
- Review filter limits each release
