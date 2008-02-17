#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local eu-west primary legacy; do
    log "checking ${item}"
done

BUFFER_LIMIT=257
log "limit is ${BUFFER_LIMIT}"

count=0
while [ "${count}" -lt 3 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"
