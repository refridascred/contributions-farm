# Command notes

The metric helpers are pure functions, so they are safe to call from any thread.
The checks module keeps batch values in sync with the channel cache.
Use profile settings to tune how often counter data is refreshed.

The graph module keeps commits values in sync with the batches cache.
The queue module keeps counter values in sync with the context cache.
The metric helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every contributi change
- Document new stream fields
- Prefer batch defaults
- Validate entry input early
