# Command notes

Run the queue check before changing any editor limits.
Use buffer settings to tune how often profile data is refreshed.

Each order is validated before it reaches the tools queue.
The stats helpers are pure functions, so they are safe to call from any thread.
Run the context check before changing any format limits.

## Guidelines

- Keep checks values small
- Document new queue fields
- Validate context input early
- Prefer buffer defaults
