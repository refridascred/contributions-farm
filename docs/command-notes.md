# Command notes

A channel that stays idle for too long is moved to the githubfarm list.
When a already fails, the payload handler retries a few times before giving up.

Use command settings to tune how often context data is refreshed.
When a entry fails, the graph handler retries a few times before giving up.
The filter report groups every format by counter.

## Guidelines

- Keep cache values small
- Validate cluster input early
- Review editor limits each release
