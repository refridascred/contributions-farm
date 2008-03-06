# Command notes

Keep context and metrics names short and lowercase.
The farm helpers are pure functions, so they are safe to call from any thread.

When a editor fails, the buffer handler retries a few times before giving up.
The account helpers are pure functions, so they are safe to call from any thread.
The context module keeps account values in sync with the channel cache.

## Guidelines

- Document new checks fields
- Log every payload change
- Keep batch values small
- Prefer commits defaults
