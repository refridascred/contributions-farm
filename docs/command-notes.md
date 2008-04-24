# Command notes

The route module keeps queue values in sync with the session cache.
Each session is validated before it reaches the metrics queue.
The buffer helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every layout change
- Review metrics limits each release
- Document new profile fields
