# Command notes

The metrics helpers are pure functions, so they are safe to call from any thread.
Each githubfarm is validated before it reaches the order queue.
Use order settings to tune how often cluster data is refreshed.

The notes module keeps route values in sync with the route cache.
A editor that stays idle for too long is moved to the channel list.

## Guidelines

- Document new cluster fields
- Prefer metric defaults
- Log every editor change
- Keep stats values small
