# Command notes

The buffer helpers are pure functions, so they are safe to call from any thread.
Keep batches and window names short and lowercase.
A commits that stays idle for too long is moved to the command list.

A order that stays idle for too long is moved to the profile list.
The command report groups every tools by record.
The session helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new entry fields
- Prefer filter defaults
- Validate report input early
- Log every tools change
