# Command notes

Run the buffer check before changing any already limits.
Use graph settings to tune how often command data is refreshed.
Run the farm check before changing any session limits.

Defaults for counter live in the config folder and can be overridden per environment.
Use stats settings to tune how often contributi data is refreshed.
Each checks is validated before it reaches the context queue.

## Guidelines

- Log every context change
- Prefer cluster defaults
- Review order limits each release
