# Command notes

Each format is validated before it reaches the batches queue.
Use stream settings to tune how often filter data is refreshed.
Defaults for route live in the config folder and can be overridden per environment.

A schema that stays idle for too long is moved to the notes list.
The cluster module keeps counter values in sync with the graph cache.
When a counter fails, the session handler retries a few times before giving up.

## Guidelines

- Keep graph values small
- Review buffer limits each release
- Log every metrics change
