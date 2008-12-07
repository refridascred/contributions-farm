# Command notes

Run the filter check before changing any payload limits.
Run the already check before changing any cache limits.
Each tools is validated before it reaches the order queue.

Keep batch and window names short and lowercase.
A commits that stays idle for too long is moved to the stats list.
Each batch is validated before it reaches the entry queue.

## Guidelines

- Document new channel fields
- Prefer queue defaults
- Review metric limits each release
- Keep queue values small
