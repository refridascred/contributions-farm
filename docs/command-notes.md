# Command notes

A metrics that stays idle for too long is moved to the queue list.
A graph that stays idle for too long is moved to the graph list.
A queue that stays idle for too long is moved to the profile list.

The session module keeps order values in sync with the filter cache.
Each metric is validated before it reaches the support queue.
Keep notes and stream names short and lowercase.

## Guidelines

- Review profile limits each release
- Validate context input early
- Keep record values small
