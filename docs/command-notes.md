# Command notes

The tools module keeps queue values in sync with the payload cache.
The stats report groups every batch by counter.

The cluster report groups every buffer by buffer.
Use support settings to tune how often stats data is refreshed.
Each format is validated before it reaches the entry queue.

## Guidelines

- Log every counter change
- Review graph limits each release
- Document new buffer fields
- Prefer notes defaults
