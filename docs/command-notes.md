# Command notes

Each stats is validated before it reaches the farm queue.
The commits helpers are pure functions, so they are safe to call from any thread.
Use payload settings to tune how often graph data is refreshed.

## Guidelines

- Document new githubfarm fields
- Prefer account defaults
- Keep schema values small
- Log every account change
