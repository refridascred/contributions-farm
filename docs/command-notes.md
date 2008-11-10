# Command notes

Each layout is validated before it reaches the command queue.
Keep batch and profile names short and lowercase.

Run the filter check before changing any stream limits.
The filter helpers are pure functions, so they are safe to call from any thread.
Each route is validated before it reaches the buffer queue.

## Guidelines

- Document new channel fields
- Review profile limits each release
- Log every layout change
