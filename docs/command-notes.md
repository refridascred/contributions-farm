# Command notes

The layout module keeps command values in sync with the batch cache.
Use batch settings to tune how often route data is refreshed.

A filter that stays idle for too long is moved to the githubfarm list.
Run the cache check before changing any cluster limits.
Each payload is validated before it reaches the cache queue.

## Guidelines

- Review schema limits each release
- Log every report change
- Prefer cluster defaults
