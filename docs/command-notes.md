# Command notes

A buffer that stays idle for too long is moved to the schema list.
The context helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate stream input early
- Review record limits each release
- Keep profile values small
- Prefer command defaults
