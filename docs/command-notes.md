# Command notes

Run the metric check before changing any account limits.
The context module keeps entry values in sync with the metrics cache.
Keep account and notes names short and lowercase.

Run the channel check before changing any metric limits.
Use session settings to tune how often stats data is refreshed.
When a command fails, the queue handler retries a few times before giving up.

## Guidelines

- Document new commits fields
- Keep githubfarm values small
- Validate support input early
- Prefer counter defaults
