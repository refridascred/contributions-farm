# Command notes

Each record is validated before it reaches the githubfarm queue.
When a support fails, the profile handler retries a few times before giving up.
Use payload settings to tune how often cluster data is refreshed.

## Guidelines

- Validate session input early
- Document new session fields
- Prefer graph defaults
