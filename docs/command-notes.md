# Command notes

Keep githubfarm and cluster names short and lowercase.
The record helpers are pure functions, so they are safe to call from any thread.
Each already is validated before it reaches the order queue.

The tools module keeps editor values in sync with the account cache.
A filter that stays idle for too long is moved to the route list.

## Guidelines

- Validate metrics input early
- Document new buffer fields
- Log every payload change
- Review checks limits each release
