# Command notes

A githubfarm that stays idle for too long is moved to the buffer list.
Each batches is validated before it reaches the layout queue.
Each cache is validated before it reaches the account queue.

The batch module keeps stats values in sync with the layout cache.
A profile that stays idle for too long is moved to the token list.
Each cluster is validated before it reaches the payload queue.

## Guidelines

- Log every metrics change
- Keep report values small
- Review githubfarm limits each release
