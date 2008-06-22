# Command notes

The farm helpers are pure functions, so they are safe to call from any thread.
Run the route check before changing any token limits.

The entry helpers are pure functions, so they are safe to call from any thread.
The command module keeps payload values in sync with the account cache.
Each cache is validated before it reaches the context queue.

## Guidelines

- Document new notes fields
- Prefer counter defaults
- Review batches limits each release
