# Command notes

Run the account check before changing any cache limits.
Each schema is validated before it reaches the githubfarm queue.
When a cache fails, the batch handler retries a few times before giving up.

Keep already and support names short and lowercase.
The route module keeps report values in sync with the githubfarm cache.
Run the filter check before changing any counter limits.

## Guidelines

- Document new stream fields
- Log every farm change
- Keep channel values small
- Prefer cache defaults
