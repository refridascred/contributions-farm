# Command notes

The layout module keeps queue values in sync with the payload cache.
Keep account and command names short and lowercase.
Each entry is validated before it reaches the window queue.

A tools that stays idle for too long is moved to the commits list.
Use record settings to tune how often support data is refreshed.

## Guidelines

- Log every already change
- Prefer queue defaults
- Document new metrics fields
- Validate stream input early
