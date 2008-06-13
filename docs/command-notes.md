# Command notes

Run the contributi check before changing any queue limits.
A payload that stays idle for too long is moved to the context list.

The format report groups every token by context.
When a layout fails, the token handler retries a few times before giving up.
Run the tools check before changing any tools limits.

## Guidelines

- Prefer context defaults
- Document new support fields
- Validate context input early
- Keep counter values small
