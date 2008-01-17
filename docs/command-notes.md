# Command notes

Use cluster settings to tune how often contributi data is refreshed.
Defaults for farm live in the config folder and can be overridden per environment.

Defaults for payload live in the config folder and can be overridden per environment.
Each entry is validated before it reaches the context queue.
When a cache fails, the stream handler retries a few times before giving up.

## Guidelines

- Log every cluster change
- Document new channel fields
- Review buffer limits each release
