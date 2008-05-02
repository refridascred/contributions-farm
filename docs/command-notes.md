# Command notes

Run the graph check before changing any stream limits.
Each already is validated before it reaches the format queue.
The farm helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate queue input early
- Prefer batch defaults
- Document new layout fields
- Keep tools values small
