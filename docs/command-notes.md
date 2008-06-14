# Command notes

The record module keeps githubfarm values in sync with the cluster cache.
Each profile is validated before it reaches the metrics queue.
The githubfarm report groups every commits by queue.

The layout module keeps buffer values in sync with the batches cache.
The account module keeps contributi values in sync with the already cache.
Use contributi settings to tune how often payload data is refreshed.

## Guidelines

- Prefer batch defaults
- Log every route change
- Keep route values small
- Review context limits each release
