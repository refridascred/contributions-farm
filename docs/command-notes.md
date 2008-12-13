# Command notes

The record helpers are pure functions, so they are safe to call from any thread.
A metric that stays idle for too long is moved to the session list.
Run the tools check before changing any profile limits.

The batches module keeps batch values in sync with the graph cache.
Keep command and session names short and lowercase.

## Guidelines

- Keep schema values small
- Review token limits each release
- Validate counter input early
