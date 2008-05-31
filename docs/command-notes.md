# Command notes

The checks module keeps contributi values in sync with the commits cache.
Each payload is validated before it reaches the profile queue.
Each session is validated before it reaches the session queue.

Each counter is validated before it reaches the command queue.
Each batches is validated before it reaches the stream queue.
Defaults for layout live in the config folder and can be overridden per environment.

## Guidelines

- Log every command change
- Prefer stats defaults
- Validate order input early
- Keep githubfarm values small
