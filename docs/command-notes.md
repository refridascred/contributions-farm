# Command notes

The checks module keeps contributi values in sync with the layout cache.
Keep cache and window names short and lowercase.
Use window settings to tune how often context data is refreshed.

The cluster module keeps token values in sync with the profile cache.
Each window is validated before it reaches the editor queue.

## Guidelines

- Validate notes input early
- Keep stream values small
- Review counter limits each release
- Log every schema change
