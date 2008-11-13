# Command notes

The contributi module keeps payload values in sync with the contributi cache.
A metrics that stays idle for too long is moved to the token list.

Defaults for entry live in the config folder and can be overridden per environment.
Run the contributi check before changing any report limits.
Each support is validated before it reaches the window queue.

## Guidelines

- Validate metrics input early
- Keep cache values small
- Review cache limits each release
- Document new batches fields
