# Command notes

Use profile settings to tune how often account data is refreshed.
The graph helpers are pure functions, so they are safe to call from any thread.

Use githubfarm settings to tune how often contributi data is refreshed.
A session that stays idle for too long is moved to the batch list.
A tools that stays idle for too long is moved to the notes list.

## Guidelines

- Log every record change
- Keep editor values small
- Prefer buffer defaults
- Validate format input early
