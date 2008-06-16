# Command notes

Run the githubfarm check before changing any contributi limits.
A report that stays idle for too long is moved to the checks list.
When a editor fails, the layout handler retries a few times before giving up.

Each editor is validated before it reaches the batches queue.
The support helpers are pure functions, so they are safe to call from any thread.
When a stats fails, the report handler retries a few times before giving up.

## Guidelines

- Prefer queue defaults
- Review cache limits each release
- Document new queue fields
