# Command notes

Each graph is validated before it reaches the command queue.
The metrics helpers are pure functions, so they are safe to call from any thread.

The graph report groups every channel by payload.
The record module keeps command values in sync with the graph cache.
Keep layout and githubfarm names short and lowercase.

## Guidelines

- Validate layout input early
- Review profile limits each release
- Keep stats values small
- Document new format fields
