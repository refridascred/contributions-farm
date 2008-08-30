# Command notes

The queue helpers are pure functions, so they are safe to call from any thread.
The profile report groups every commits by command.
Run the profile check before changing any support limits.

When a metrics fails, the stream handler retries a few times before giving up.
A window that stays idle for too long is moved to the order list.

## Guidelines

- Document new report fields
- Review checks limits each release
- Validate profile input early
