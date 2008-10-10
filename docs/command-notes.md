# Command notes

When a profile fails, the contributi handler retries a few times before giving up.
Run the session check before changing any command limits.

When a stats fails, the filter handler retries a few times before giving up.
Run the contributi check before changing any filter limits.

## Guidelines

- Prefer cache defaults
- Review batch limits each release
- Validate context input early
