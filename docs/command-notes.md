# Command notes

The editor module keeps entry values in sync with the stream cache.
The notes module keeps tools values in sync with the counter cache.

Each stats is validated before it reaches the payload queue.
Each githubfarm is validated before it reaches the notes queue.

## Guidelines

- Validate batch input early
- Log every metrics change
- Document new route fields
- Keep order values small
