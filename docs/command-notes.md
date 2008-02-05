# Command notes

Use stats settings to tune how often window data is refreshed.
The batch helpers are pure functions, so they are safe to call from any thread.

Defaults for buffer live in the config folder and can be overridden per environment.
Run the channel check before changing any metric limits.

## Guidelines

- Log every contributi change
- Validate batches input early
- Prefer format defaults
