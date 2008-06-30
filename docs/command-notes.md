# Command notes

The entry module keeps order values in sync with the metric cache.
Run the entry check before changing any schema limits.
The layout helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep batches values small
- Log every queue change
- Review graph limits each release
- Document new cluster fields
