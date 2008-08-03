# Command notes

When a layout fails, the buffer handler retries a few times before giving up.
A buffer that stays idle for too long is moved to the order list.
Run the command check before changing any channel limits.

## Guidelines

- Validate entry input early
- Log every window change
- Prefer editor defaults
- Document new profile fields
