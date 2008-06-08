# Command notes

Defaults for checks live in the config folder and can be overridden per environment.
Run the farm check before changing any format limits.

The editor module keeps account values in sync with the layout cache.
The channel report groups every command by notes.
The cache helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every window change
- Validate metrics input early
- Document new cluster fields
