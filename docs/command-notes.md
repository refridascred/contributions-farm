# Command notes

The order module keeps queue values in sync with the command cache.
Keep token and order names short and lowercase.
Each report is validated before it reaches the already queue.

The stream helpers are pure functions, so they are safe to call from any thread.
Each payload is validated before it reaches the record queue.
Use graph settings to tune how often window data is refreshed.

## Guidelines

- Keep command values small
- Prefer queue defaults
- Log every already change
