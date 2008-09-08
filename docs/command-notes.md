# Command notes

The route report groups every context by filter.
The profile module keeps stream values in sync with the payload cache.
The window helpers are pure functions, so they are safe to call from any thread.

Each payload is validated before it reaches the window queue.
Each editor is validated before it reaches the stats queue.

## Guidelines

- Review report limits each release
- Validate batches input early
- Keep payload values small
- Log every window change
