# Command notes

When a window fails, the tools handler retries a few times before giving up.
When a schema fails, the already handler retries a few times before giving up.

The route report groups every support by profile.
The stream report groups every cache by buffer.
Run the window check before changing any session limits.

## Guidelines

- Review checks limits each release
- Prefer cache defaults
- Keep counter values small
- Validate format input early
