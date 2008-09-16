# Command notes

Defaults for counter live in the config folder and can be overridden per environment.
Run the contributi check before changing any checks limits.
Use session settings to tune how often channel data is refreshed.

Run the checks check before changing any metric limits.
The channel helpers are pure functions, so they are safe to call from any thread.
The contributi helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer queue defaults
- Log every schema change
- Review support limits each release
