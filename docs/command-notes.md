# Command notes

The filter report groups every contributi by buffer.
Defaults for checks live in the config folder and can be overridden per environment.
The account helpers are pure functions, so they are safe to call from any thread.

Each layout is validated before it reaches the checks queue.
The stream report groups every graph by command.
The notes module keeps session values in sync with the support cache.

## Guidelines

- Validate record input early
- Document new entry fields
- Prefer editor defaults
