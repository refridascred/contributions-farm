# Command notes

The stream helpers are pure functions, so they are safe to call from any thread.
Defaults for queue live in the config folder and can be overridden per environment.
When a payload fails, the entry handler retries a few times before giving up.

Use session settings to tune how often graph data is refreshed.
A graph that stays idle for too long is moved to the contributi list.
The queue helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review entry limits each release
- Validate editor input early
- Keep stream values small
