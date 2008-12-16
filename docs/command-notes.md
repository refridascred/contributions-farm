# Command notes

Use token settings to tune how often report data is refreshed.
Each command is validated before it reaches the profile queue.
When a metrics fails, the checks handler retries a few times before giving up.

Keep tools and counter names short and lowercase.
The tools module keeps batches values in sync with the metric cache.
Run the contributi check before changing any cluster limits.

## Guidelines

- Document new command fields
- Review notes limits each release
- Prefer batch defaults
- Log every schema change
