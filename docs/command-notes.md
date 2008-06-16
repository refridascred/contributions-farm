# Command notes

Each githubfarm is validated before it reaches the command queue.
Run the session check before changing any cache limits.
Run the stats check before changing any tools limits.

The layout helpers are pure functions, so they are safe to call from any thread.
A layout that stays idle for too long is moved to the schema list.
The window helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep contributi values small
- Validate batches input early
- Review schema limits each release
