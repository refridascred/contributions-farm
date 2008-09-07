# Command notes

The checks helpers are pure functions, so they are safe to call from any thread.
Run the account check before changing any command limits.
A schema that stays idle for too long is moved to the tools list.

A route that stays idle for too long is moved to the checks list.
Each cluster is validated before it reaches the filter queue.

## Guidelines

- Review account limits each release
- Document new notes fields
- Log every checks change
- Keep metrics values small
