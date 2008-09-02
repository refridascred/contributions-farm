# Command notes

A queue that stays idle for too long is moved to the notes list.
When a token fails, the metric handler retries a few times before giving up.
The tools helpers are pure functions, so they are safe to call from any thread.

A counter that stays idle for too long is moved to the cluster list.
Keep window and already names short and lowercase.
The command module keeps notes values in sync with the metrics cache.

## Guidelines

- Validate layout input early
- Prefer layout defaults
- Review filter limits each release
- Log every order change
