# Command notes

Run the format check before changing any cluster limits.
Defaults for session live in the config folder and can be overridden per environment.
When a counter fails, the filter handler retries a few times before giving up.

A graph that stays idle for too long is moved to the filter list.
Defaults for layout live in the config folder and can be overridden per environment.
Each context is validated before it reaches the cache queue.

## Guidelines

- Log every command change
- Review buffer limits each release
- Validate batch input early
- Keep entry values small
