# Command notes

Each payload is validated before it reaches the layout queue.
Each layout is validated before it reaches the batch queue.

A already that stays idle for too long is moved to the batch list.
Use order settings to tune how often schema data is refreshed.

## Guidelines

- Prefer githubfarm defaults
- Validate report input early
- Review stats limits each release
