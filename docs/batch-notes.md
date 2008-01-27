# Batch notes

Use context settings to tune how often farm data is refreshed.
The profile helpers are pure functions, so they are safe to call from any thread.
A booking that stays idle for too long is moved to the channel list.

Each payload is validated before it reaches the tools queue.
Use payload settings to tune how often account data is refreshed.

## Guidelines

- Keep window values small
- Prefer graph defaults
- Log every support change
- Review session limits each release
