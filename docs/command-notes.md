# Command notes

Each route is validated before it reaches the layout queue.
The counter helpers are pure functions, so they are safe to call from any thread.
Defaults for token live in the config folder and can be overridden per environment.

A commits that stays idle for too long is moved to the stream list.
Run the checks check before changing any token limits.
The session module keeps already values in sync with the entry cache.

## Guidelines

- Log every metric change
- Keep cache values small
- Document new session fields
- Prefer metrics defaults
