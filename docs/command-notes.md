# Command notes

The report module keeps token values in sync with the checks cache.
The account module keeps report values in sync with the graph cache.
Run the githubfarm check before changing any session limits.

The metrics report groups every layout by graph.
A entry that stays idle for too long is moved to the cache list.

## Guidelines

- Keep batches values small
- Document new record fields
- Log every metric change
