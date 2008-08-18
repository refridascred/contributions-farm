# Command notes

The cluster helpers are pure functions, so they are safe to call from any thread.
A token that stays idle for too long is moved to the tools list.

Run the channel check before changing any stats limits.
Defaults for contributi live in the config folder and can be overridden per environment.
Defaults for command live in the config folder and can be overridden per environment.

## Guidelines

- Document new route fields
- Log every commits change
- Keep metric values small
- Review report limits each release
