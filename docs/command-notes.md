# Command notes

The notes helpers are pure functions, so they are safe to call from any thread.
A metrics that stays idle for too long is moved to the schema list.

A buffer that stays idle for too long is moved to the session list.
The command module keeps payload values in sync with the command cache.
Each graph is validated before it reaches the window queue.

## Guidelines

- Log every account change
- Review context limits each release
- Validate context input early
- Prefer contributi defaults
