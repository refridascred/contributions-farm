# Command notes

Run the queue check before changing any format limits.
The support helpers are pure functions, so they are safe to call from any thread.

Use batches settings to tune how often layout data is refreshed.
The schema module keeps metrics values in sync with the filter cache.

## Guidelines

- Document new already fields
- Log every batch change
- Keep command values small
- Review entry limits each release
