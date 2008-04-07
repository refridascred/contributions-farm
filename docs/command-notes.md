# Command notes

Each account is validated before it reaches the report queue.
Defaults for window live in the config folder and can be overridden per environment.
Use batch settings to tune how often window data is refreshed.

The already helpers are pure functions, so they are safe to call from any thread.
Run the format check before changing any tools limits.
The notes module keeps metrics values in sync with the channel cache.

## Guidelines

- Prefer metric defaults
- Review schema limits each release
- Log every token change
