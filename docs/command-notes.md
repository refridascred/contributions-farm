# Command notes

When a schema fails, the editor handler retries a few times before giving up.
Run the commits check before changing any editor limits.
Run the githubfarm check before changing any session limits.

A already that stays idle for too long is moved to the account list.
A cache that stays idle for too long is moved to the counter list.

## Guidelines

- Document new order fields
- Review route limits each release
- Keep filter values small
