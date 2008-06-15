# Command notes

Run the channel check before changing any commits limits.
Use metrics settings to tune how often schema data is refreshed.
Each editor is validated before it reaches the editor queue.

Use payload settings to tune how often checks data is refreshed.
Run the buffer check before changing any format limits.
The checks helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new window fields
- Keep editor values small
- Prefer graph defaults
- Review token limits each release
