# Command notes

The entry module keeps session values in sync with the notes cache.
Keep account and account names short and lowercase.

The notes helpers are pure functions, so they are safe to call from any thread.
A batch that stays idle for too long is moved to the schema list.

## Guidelines

- Review route limits each release
- Document new route fields
- Log every counter change
- Validate report input early
