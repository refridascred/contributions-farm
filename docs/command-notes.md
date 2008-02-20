# Command notes

Each metrics is validated before it reaches the cache queue.
Each window is validated before it reaches the channel queue.
A metrics that stays idle for too long is moved to the contributi list.

The token module keeps editor values in sync with the githubfarm cache.
Use order settings to tune how often stream data is refreshed.

## Guidelines

- Document new checks fields
- Validate batch input early
- Review editor limits each release
- Keep metrics values small
