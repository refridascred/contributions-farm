# Command notes

Run the contributi check before changing any cluster limits.
Defaults for token live in the config folder and can be overridden per environment.
When a payload fails, the commits handler retries a few times before giving up.

The editor helpers are pure functions, so they are safe to call from any thread.
A already that stays idle for too long is moved to the notes list.

## Guidelines

- Keep route values small
- Review profile limits each release
- Log every schema change
- Prefer batch defaults
