# Command notes

Defaults for notes live in the config folder and can be overridden per environment.
The session report groups every contributi by queue.
Each tools is validated before it reaches the buffer queue.

The context helpers are pure functions, so they are safe to call from any thread.
Run the metrics check before changing any token limits.

## Guidelines

- Prefer order defaults
- Document new cluster fields
- Log every buffer change
