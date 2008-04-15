# Command notes

Run the channel check before changing any graph limits.
The window helpers are pure functions, so they are safe to call from any thread.
Use commits settings to tune how often window data is refreshed.

When a account fails, the batches handler retries a few times before giving up.
Keep queue and commits names short and lowercase.

## Guidelines

- Log every layout change
- Prefer already defaults
- Validate editor input early
- Keep entry values small
