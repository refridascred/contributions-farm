# Command notes

Keep githubfarm and notes names short and lowercase.
The entry module keeps command values in sync with the metric cache.

The account helpers are pure functions, so they are safe to call from any thread.
A record that stays idle for too long is moved to the githubfarm list.

## Guidelines

- Prefer batches defaults
- Keep metrics values small
- Document new token fields
- Review batches limits each release
