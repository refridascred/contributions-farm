# Command notes

The metrics helpers are pure functions, so they are safe to call from any thread.
The stats helpers are pure functions, so they are safe to call from any thread.
Use token settings to tune how often githubfarm data is refreshed.

Keep window and order names short and lowercase.
Each schema is validated before it reaches the tools queue.

## Guidelines

- Log every counter change
- Keep counter values small
- Prefer cache defaults
