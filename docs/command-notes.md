# Command notes

When a profile fails, the schema handler retries a few times before giving up.
A command that stays idle for too long is moved to the stream list.
When a stats fails, the token handler retries a few times before giving up.

## Guidelines

- Document new cluster fields
- Keep support values small
- Review contributi limits each release
