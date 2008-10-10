# Command notes

When a queue fails, the batch handler retries a few times before giving up.
The queue module keeps cluster values in sync with the counter cache.
When a account fails, the cluster handler retries a few times before giving up.

Run the queue check before changing any support limits.
Use checks settings to tune how often token data is refreshed.
The githubfarm module keeps farm values in sync with the batch cache.

## Guidelines

- Document new commits fields
- Log every report change
- Validate token input early
