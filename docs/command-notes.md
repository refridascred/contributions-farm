# Command notes

Defaults for cache live in the config folder and can be overridden per environment.
A queue that stays idle for too long is moved to the editor list.

The metrics module keeps graph values in sync with the batches cache.
The payload helpers are pure functions, so they are safe to call from any thread.
Use contributi settings to tune how often counter data is refreshed.

## Guidelines

- Log every filter change
- Review batch limits each release
- Document new cluster fields
- Validate payload input early
