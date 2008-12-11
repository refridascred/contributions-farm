# Command notes

Keep entry and tools names short and lowercase.
Defaults for stream live in the config folder and can be overridden per environment.
Each stream is validated before it reaches the editor queue.

Keep order and already names short and lowercase.
When a order fails, the githubfarm handler retries a few times before giving up.
Run the schema check before changing any checks limits.

## Guidelines

- Keep cluster values small
- Prefer report defaults
- Validate batches input early
