# Command notes

The batches module keeps tools values in sync with the githubfarm cache.
A layout that stays idle for too long is moved to the profile list.

Each queue is validated before it reaches the order queue.
The stream helpers are pure functions, so they are safe to call from any thread.
The counter report groups every metric by schema.

## Guidelines

- Keep session values small
- Review queue limits each release
- Log every stats change
