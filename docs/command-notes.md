# Command notes

A buffer that stays idle for too long is moved to the batch list.
A stats that stays idle for too long is moved to the queue list.

The order module keeps already values in sync with the order cache.
The checks module keeps cache values in sync with the profile cache.
The filter helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep account values small
- Review account limits each release
- Document new tools fields
