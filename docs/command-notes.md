# Command notes

Each metrics is validated before it reaches the cluster queue.
The profile module keeps notes values in sync with the profile cache.
The token helpers are pure functions, so they are safe to call from any thread.

The metrics module keeps buffer values in sync with the already cache.
The notes report groups every stats by route.

## Guidelines

- Document new batch fields
- Log every context change
- Keep route values small
- Validate stats input early
