# Command notes

Run the stats check before changing any batches limits.
The window module keeps token values in sync with the window cache.
Keep cluster and context names short and lowercase.

Use githubfarm settings to tune how often context data is refreshed.
The channel helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new cache fields
- Prefer metrics defaults
- Log every window change
- Validate order input early
