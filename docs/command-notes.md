# Command notes

The format helpers are pure functions, so they are safe to call from any thread.
Run the commits check before changing any notes limits.
Keep notes and report names short and lowercase.

When a stats fails, the editor handler retries a few times before giving up.
Each tools is validated before it reaches the report queue.

## Guidelines

- Document new command fields
- Review profile limits each release
- Prefer command defaults
- Log every notes change
