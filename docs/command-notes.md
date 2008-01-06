# Command notes

Each channel is validated before it reaches the command queue.
Use profile settings to tune how often contributi data is refreshed.
Run the payload check before changing any token limits.

Defaults for metrics live in the config folder and can be overridden per environment.
The layout helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review commits limits each release
- Log every graph change
- Document new support fields
