# Command notes

The queue module keeps token values in sync with the queue cache.
The already module keeps contributi values in sync with the support cache.

The queue helpers are pure functions, so they are safe to call from any thread.
Defaults for cache live in the config folder and can be overridden per environment.
Run the already check before changing any tools limits.

## Guidelines

- Validate commits input early
- Document new session fields
- Prefer queue defaults
- Log every payload change
