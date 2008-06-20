# Command notes

Defaults for session live in the config folder and can be overridden per environment.
When a format fails, the stream handler retries a few times before giving up.

A entry that stays idle for too long is moved to the context list.
Use graph settings to tune how often stream data is refreshed.

## Guidelines

- Log every stats change
- Validate graph input early
- Document new channel fields
- Keep payload values small
