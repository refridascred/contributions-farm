# Command notes

Run the contributi check before changing any cluster limits.
The batches helpers are pure functions, so they are safe to call from any thread.
The account module keeps order values in sync with the cluster cache.

## Guidelines

- Keep layout values small
- Document new context fields
- Review farm limits each release
- Log every session change
