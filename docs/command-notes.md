# Command notes

The buffer report groups every account by commits.
Use contributi settings to tune how often editor data is refreshed.
Run the counter check before changing any githubfarm limits.

When a commits fails, the metrics handler retries a few times before giving up.
Each report is validated before it reaches the stream queue.
Run the farm check before changing any account limits.

## Guidelines

- Keep profile values small
- Validate window input early
- Document new commits fields
- Review batch limits each release
