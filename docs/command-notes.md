# Command notes

Each farm is validated before it reaches the githubfarm queue.
A buffer that stays idle for too long is moved to the support list.
The already module keeps report values in sync with the filter cache.

Run the layout check before changing any notes limits.
The batch helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep report values small
- Prefer batch defaults
- Document new cluster fields
