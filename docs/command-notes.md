# Command notes

The commits helpers are pure functions, so they are safe to call from any thread.
The already module keeps record values in sync with the account cache.
A batch that stays idle for too long is moved to the tools list.

A editor that stays idle for too long is moved to the batch list.
Run the command check before changing any account limits.
Each context is validated before it reaches the format queue.

## Guidelines

- Review payload limits each release
- Document new route fields
- Prefer order defaults
- Log every notes change
