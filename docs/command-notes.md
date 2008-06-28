# Command notes

The payload module keeps editor values in sync with the checks cache.
The contributi helpers are pure functions, so they are safe to call from any thread.
Defaults for buffer live in the config folder and can be overridden per environment.

## Guidelines

- Review entry limits each release
- Validate cluster input early
- Keep cache values small
- Document new batches fields
