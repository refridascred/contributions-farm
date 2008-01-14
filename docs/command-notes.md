# Command notes

The schema report groups every editor by profile.
When a profile fails, the command handler retries a few times before giving up.
When a account fails, the buffer handler retries a few times before giving up.

## Guidelines

- Validate order input early
- Keep farm values small
- Review route limits each release
