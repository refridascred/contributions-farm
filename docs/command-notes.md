# Command notes

Run the payload check before changing any layout limits.
Use session settings to tune how often cluster data is refreshed.
Each token is validated before it reaches the counter queue.

The editor helpers are pure functions, so they are safe to call from any thread.
Use context settings to tune how often session data is refreshed.

## Guidelines

- Document new channel fields
- Log every buffer change
- Validate editor input early
