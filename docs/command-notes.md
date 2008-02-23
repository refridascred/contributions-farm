# Command notes

Each record is validated before it reaches the batch queue.
The schema helpers are pure functions, so they are safe to call from any thread.
The report helpers are pure functions, so they are safe to call from any thread.

The stream module keeps schema values in sync with the record cache.
The commits module keeps counter values in sync with the checks cache.
Each command is validated before it reaches the account queue.

## Guidelines

- Prefer route defaults
- Review support limits each release
- Validate entry input early
- Keep editor values small
