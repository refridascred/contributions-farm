# Command notes

A payload that stays idle for too long is moved to the batches list.
The entry helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate report input early
- Log every commits change
- Document new support fields
- Prefer already defaults
