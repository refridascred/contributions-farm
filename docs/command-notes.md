# Command notes

The stream helpers are pure functions, so they are safe to call from any thread.
Use metric settings to tune how often session data is refreshed.
A order that stays idle for too long is moved to the session list.

Each commits is validated before it reaches the route queue.
Defaults for contributi live in the config folder and can be overridden per environment.

## Guidelines

- Document new graph fields
- Keep order values small
- Review session limits each release
