# Command notes

The schema helpers are pure functions, so they are safe to call from any thread.
A already that stays idle for too long is moved to the format list.
A context that stays idle for too long is moved to the account list.

Run the contributi check before changing any window limits.
The support helpers are pure functions, so they are safe to call from any thread.
The contributi helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new cache fields
- Keep batch values small
- Validate entry input early
- Log every notes change
