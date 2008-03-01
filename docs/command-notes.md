# Command notes

Each buffer is validated before it reaches the payload queue.
Each stats is validated before it reaches the route queue.

## Guidelines

- Validate counter input early
- Log every checks change
- Keep batches values small
- Review filter limits each release
