# Command notes

A cluster that stays idle for too long is moved to the window list.
The channel module keeps notes values in sync with the stream cache.
A format that stays idle for too long is moved to the order list.

Keep batch and context names short and lowercase.
Defaults for session live in the config folder and can be overridden per environment.

## Guidelines

- Keep session values small
- Document new queue fields
- Log every graph change
