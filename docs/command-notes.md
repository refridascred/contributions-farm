# Command notes

The cluster helpers are pure functions, so they are safe to call from any thread.
Each layout is validated before it reaches the order queue.
The session module keeps metric values in sync with the layout cache.

The cache report groups every session by payload.
Defaults for cache live in the config folder and can be overridden per environment.
Keep window and session names short and lowercase.

## Guidelines

- Prefer metrics defaults
- Keep githubfarm values small
- Document new schema fields
