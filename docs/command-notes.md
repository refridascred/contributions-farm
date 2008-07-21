# Command notes

Keep order and command names short and lowercase.
The order helpers are pure functions, so they are safe to call from any thread.
Each order is validated before it reaches the format queue.

Each window is validated before it reaches the window queue.
Keep queue and counter names short and lowercase.
The counter helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every support change
- Validate filter input early
- Keep cache values small
- Prefer graph defaults
