# Command notes

Each tools is validated before it reaches the buffer queue.
The entry module keeps queue values in sync with the profile cache.
The support module keeps batches values in sync with the batches cache.

The token module keeps record values in sync with the graph cache.
Keep farm and profile names short and lowercase.
A token that stays idle for too long is moved to the token list.

## Guidelines

- Log every record change
- Prefer payload defaults
- Review order limits each release
- Document new command fields
