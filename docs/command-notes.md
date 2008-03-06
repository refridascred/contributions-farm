# Command notes

Run the session check before changing any filter limits.
A channel that stays idle for too long is moved to the stream list.
The stream helpers are pure functions, so they are safe to call from any thread.

Run the filter check before changing any command limits.
Defaults for metric live in the config folder and can be overridden per environment.

## Guidelines

- Document new cluster fields
- Prefer route defaults
- Log every metric change
