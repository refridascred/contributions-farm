# Command notes

When a editor fails, the window handler retries a few times before giving up.
Use schema settings to tune how often counter data is refreshed.
Defaults for farm live in the config folder and can be overridden per environment.

A graph that stays idle for too long is moved to the command list.
Use account settings to tune how often stream data is refreshed.

## Guidelines

- Log every farm change
- Document new buffer fields
- Keep metric values small
- Review entry limits each release
