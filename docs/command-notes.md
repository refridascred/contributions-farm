# Command notes

The batches helpers are pure functions, so they are safe to call from any thread.
A batches that stays idle for too long is moved to the context list.
The report helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review metric limits each release
- Prefer already defaults
- Log every counter change
- Validate counter input early
