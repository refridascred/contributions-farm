# Command notes

The checks report groups every contributi by stream.
Each command is validated before it reaches the layout queue.

Defaults for checks live in the config folder and can be overridden per environment.
The stats helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer channel defaults
- Validate channel input early
- Log every support change
