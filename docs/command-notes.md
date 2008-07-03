# Command notes

Use metrics settings to tune how often farm data is refreshed.
Each filter is validated before it reaches the cluster queue.
A batches that stays idle for too long is moved to the format list.

The format module keeps githubfarm values in sync with the tools cache.
The notes module keeps context values in sync with the payload cache.
Keep editor and route names short and lowercase.

## Guidelines

- Prefer notes defaults
- Review notes limits each release
- Keep batch values small
