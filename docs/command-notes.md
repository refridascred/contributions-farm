# Command notes

Run the counter check before changing any channel limits.
The session helpers are pure functions, so they are safe to call from any thread.
Each account is validated before it reaches the checks queue.

## Guidelines

- Log every support change
- Document new account fields
- Keep context values small
