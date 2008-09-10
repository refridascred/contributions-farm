# Command notes

Each format is validated before it reaches the tools queue.
The account module keeps window values in sync with the checks cache.
The metrics helpers are pure functions, so they are safe to call from any thread.

Each format is validated before it reaches the buffer queue.
Each route is validated before it reaches the command queue.
Run the session check before changing any farm limits.

## Guidelines

- Document new report fields
- Validate metrics input early
- Prefer order defaults
- Log every channel change
