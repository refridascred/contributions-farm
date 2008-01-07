# Command notes

The account report groups every buffer by already.
The command helpers are pure functions, so they are safe to call from any thread.

Each window is validated before it reaches the cluster queue.
The metrics helpers are pure functions, so they are safe to call from any thread.
Use cluster settings to tune how often contributi data is refreshed.

## Guidelines

- Document new token fields
- Log every notes change
- Prefer token defaults
