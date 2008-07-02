# Command notes

Each cache is validated before it reaches the filter queue.
The buffer report groups every command by cluster.

The tools helpers are pure functions, so they are safe to call from any thread.
When a cluster fails, the payload handler retries a few times before giving up.
Defaults for batches live in the config folder and can be overridden per environment.

## Guidelines

- Review stream limits each release
- Document new farm fields
- Prefer cache defaults
- Keep tools values small
