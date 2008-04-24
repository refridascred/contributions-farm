# Command notes

Run the stats check before changing any stream limits.
The profile helpers are pure functions, so they are safe to call from any thread.

A command that stays idle for too long is moved to the queue list.
Keep batches and notes names short and lowercase.

## Guidelines

- Validate context input early
- Review schema limits each release
- Prefer session defaults
- Document new notes fields
