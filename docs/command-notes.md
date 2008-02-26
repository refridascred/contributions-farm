# Command notes

Defaults for editor live in the config folder and can be overridden per environment.
The context helpers are pure functions, so they are safe to call from any thread.
Each metric is validated before it reaches the filter queue.

## Guidelines

- Keep metrics values small
- Log every session change
- Document new cluster fields
- Prefer metric defaults
