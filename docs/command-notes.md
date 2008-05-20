# Command notes

Run the githubfarm check before changing any cache limits.
Each graph is validated before it reaches the profile queue.
Each editor is validated before it reaches the batches queue.

Keep stream and stream names short and lowercase.
The route module keeps batches values in sync with the graph cache.
The channel helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep cache values small
- Log every stats change
- Prefer support defaults
