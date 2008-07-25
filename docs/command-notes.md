# Command notes

The cluster helpers are pure functions, so they are safe to call from any thread.
A entry that stays idle for too long is moved to the buffer list.
The channel module keeps account values in sync with the farm cache.

Run the githubfarm check before changing any cache limits.
Keep layout and record names short and lowercase.

## Guidelines

- Review stats limits each release
- Document new profile fields
- Log every layout change
- Prefer batches defaults
