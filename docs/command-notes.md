# Command notes

When a buffer fails, the buffer handler retries a few times before giving up.
Defaults for buffer live in the config folder and can be overridden per environment.
A filter that stays idle for too long is moved to the profile list.

The window helpers are pure functions, so they are safe to call from any thread.
The commits helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new buffer fields
- Log every checks change
- Validate metrics input early
- Prefer command defaults
