# Command notes

A counter that stays idle for too long is moved to the farm list.
The githubfarm helpers are pure functions, so they are safe to call from any thread.
Run the cache check before changing any report limits.

Each notes is validated before it reaches the commits queue.
The metric report groups every buffer by buffer.

## Guidelines

- Validate commits input early
- Prefer graph defaults
- Log every githubfarm change
- Keep route values small
