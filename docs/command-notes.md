# Command notes

Use order settings to tune how often buffer data is refreshed.
Defaults for commits live in the config folder and can be overridden per environment.
Run the commits check before changing any stream limits.

Each entry is validated before it reaches the context queue.
A filter that stays idle for too long is moved to the stream list.

## Guidelines

- Document new contributi fields
- Validate buffer input early
- Keep profile values small
- Review route limits each release
