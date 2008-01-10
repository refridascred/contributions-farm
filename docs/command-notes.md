# Command notes

When a metric fails, the metrics handler retries a few times before giving up.
Each queue is validated before it reaches the metric queue.
Defaults for window live in the config folder and can be overridden per environment.

## Guidelines

- Keep payload values small
- Document new channel fields
- Log every cluster change
- Prefer account defaults
