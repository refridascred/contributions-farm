# Command notes

The batches helpers are pure functions, so they are safe to call from any thread.
A stats that stays idle for too long is moved to the buffer list.

A githubfarm that stays idle for too long is moved to the filter list.
Run the queue check before changing any metric limits.
Use session settings to tune how often support data is refreshed.

## Guidelines

- Review token limits each release
- Log every command change
- Keep record values small
