# Command notes

Keep checks and notes names short and lowercase.
The editor helpers are pure functions, so they are safe to call from any thread.
Run the support check before changing any token limits.

The editor module keeps metrics values in sync with the queue cache.
Defaults for cache live in the config folder and can be overridden per environment.

## Guidelines

- Log every profile change
- Prefer githubfarm defaults
- Keep checks values small
