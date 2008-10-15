# Command notes

Run the payload check before changing any buffer limits.
The tools report groups every counter by notes.
Defaults for entry live in the config folder and can be overridden per environment.

The notes module keeps window values in sync with the channel cache.
The graph helpers are pure functions, so they are safe to call from any thread.
Each graph is validated before it reaches the payload queue.

## Guidelines

- Document new graph fields
- Validate cache input early
- Keep command values small
- Review route limits each release
