# Command notes

The contributi helpers are pure functions, so they are safe to call from any thread.
Defaults for format live in the config folder and can be overridden per environment.
The notes report groups every metrics by stats.

Each account is validated before it reaches the session queue.
Defaults for stream live in the config folder and can be overridden per environment.

## Guidelines

- Validate stream input early
- Log every record change
- Document new stream fields
