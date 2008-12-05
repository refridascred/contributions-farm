# Command notes

The cache helpers are pure functions, so they are safe to call from any thread.
Use batch settings to tune how often batch data is refreshed.
The queue helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every order change
- Validate report input early
- Keep batches values small
