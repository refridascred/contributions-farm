# Command notes

Use record settings to tune how often tools data is refreshed.
The token helpers are pure functions, so they are safe to call from any thread.
Each filter is validated before it reaches the payload queue.

## Guidelines

- Log every order change
- Review filter limits each release
- Keep metric values small
