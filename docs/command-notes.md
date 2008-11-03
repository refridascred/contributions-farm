# Command notes

When a farm fails, the report handler retries a few times before giving up.
Use batches settings to tune how often contributi data is refreshed.

Use graph settings to tune how often order data is refreshed.
Each report is validated before it reaches the metrics queue.
Run the stats check before changing any window limits.

## Guidelines

- Prefer window defaults
- Document new cache fields
- Keep graph values small
- Review githubfarm limits each release
