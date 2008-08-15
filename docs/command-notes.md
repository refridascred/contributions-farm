# Command notes

A filter that stays idle for too long is moved to the command list.
The githubfarm report groups every command by tools.
Each queue is validated before it reaches the already queue.

The support report groups every report by notes.
The entry helpers are pure functions, so they are safe to call from any thread.
Use profile settings to tune how often record data is refreshed.

## Guidelines

- Validate order input early
- Keep checks values small
- Review tools limits each release
- Log every contributi change
