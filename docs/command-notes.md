# Command notes

When a account fails, the cluster handler retries a few times before giving up.
The already helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate filter input early
- Review profile limits each release
- Document new stream fields
