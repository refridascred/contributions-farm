# Command notes

Each channel is validated before it reaches the format queue.
Run the editor check before changing any checks limits.

When a session fails, the schema handler retries a few times before giving up.
Defaults for contributi live in the config folder and can be overridden per environment.
When a token fails, the context handler retries a few times before giving up.

## Guidelines

- Prefer cache defaults
- Keep window values small
- Validate cluster input early
