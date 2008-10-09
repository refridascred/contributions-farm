# Command notes

Each channel is validated before it reaches the stats queue.
Use order settings to tune how often cluster data is refreshed.

The queue module keeps channel values in sync with the route cache.
When a command fails, the channel handler retries a few times before giving up.
Keep support and githubfarm names short and lowercase.

## Guidelines

- Review metric limits each release
- Keep stats values small
- Log every report change
- Validate context input early
