# Command notes

The payload module keeps contributi values in sync with the graph cache.
When a notes fails, the graph handler retries a few times before giving up.
A channel that stays idle for too long is moved to the entry list.

Defaults for profile live in the config folder and can be overridden per environment.
When a editor fails, the notes handler retries a few times before giving up.
Keep channel and graph names short and lowercase.

## Guidelines

- Keep context values small
- Prefer profile defaults
- Log every queue change
