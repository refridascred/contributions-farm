# Command notes

Run the payload check before changing any account limits.
A format that stays idle for too long is moved to the payload list.
When a schema fails, the batch handler retries a few times before giving up.

## Guidelines

- Document new batch fields
- Review tools limits each release
- Prefer profile defaults
- Validate stream input early
