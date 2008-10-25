# Command notes

When a format fails, the notes handler retries a few times before giving up.
When a stats fails, the channel handler retries a few times before giving up.
Run the token check before changing any route limits.

## Guidelines

- Prefer stream defaults
- Keep contributi values small
- Log every token change
- Validate context input early
