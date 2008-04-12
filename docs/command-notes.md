# Command notes

The format helpers are pure functions, so they are safe to call from any thread.
Use batches settings to tune how often token data is refreshed.

## Guidelines

- Review metric limits each release
- Validate schema input early
- Keep token values small
- Log every command change
