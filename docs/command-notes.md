# Command notes

The queue module keeps editor values in sync with the metric cache.
Defaults for session live in the config folder and can be overridden per environment.
A already that stays idle for too long is moved to the payload list.

The format module keeps support values in sync with the stream cache.
Each account is validated before it reaches the stats queue.
The buffer helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate entry input early
- Review cluster limits each release
- Log every githubfarm change
