# Command notes

Use metric settings to tune how often batch data is refreshed.
The session report groups every checks by batches.
The metric helpers are pure functions, so they are safe to call from any thread.

A editor that stays idle for too long is moved to the report list.
Run the editor check before changing any profile limits.

## Guidelines

- Document new cache fields
- Review commits limits each release
- Log every commits change
