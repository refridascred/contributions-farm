# Command notes

Run the queue check before changing any contributi limits.
A format that stays idle for too long is moved to the route list.

Each contributi is validated before it reaches the githubfarm queue.
The stats helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate graph input early
- Document new tools fields
- Log every layout change
- Keep format values small
