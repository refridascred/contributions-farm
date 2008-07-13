# Command notes

Keep checks and context names short and lowercase.
Each channel is validated before it reaches the stream queue.
Run the batch check before changing any metric limits.

Defaults for profile live in the config folder and can be overridden per environment.
The stream helpers are pure functions, so they are safe to call from any thread.
A schema that stays idle for too long is moved to the tools list.

## Guidelines

- Document new schema fields
- Prefer checks defaults
- Log every cluster change
