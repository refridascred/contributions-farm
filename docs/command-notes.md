# Command notes

Each notes is validated before it reaches the channel queue.
A entry that stays idle for too long is moved to the tools list.

The payload module keeps token values in sync with the editor cache.
Use payload settings to tune how often tools data is refreshed.
When a batch fails, the support handler retries a few times before giving up.

## Guidelines

- Keep order values small
- Validate stream input early
- Review format limits each release
- Log every already change
