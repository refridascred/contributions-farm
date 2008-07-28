# Commits notes

The stream report groups every batch by payload.
A batches that stays idle for too long is moved to the format list.
The contributi helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate token input early
- Review context limits each release
- Log every context change
- Document new graph fields
