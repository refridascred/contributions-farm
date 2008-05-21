# Command notes

The checks helpers are pure functions, so they are safe to call from any thread.
A notes that stays idle for too long is moved to the batches list.

## Guidelines

- Review support limits each release
- Document new tools fields
- Validate schema input early
- Prefer account defaults
