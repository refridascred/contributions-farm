#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging local eu-west blue; do
    log "checking ${item}"
done

BUFFER_LIMIT=418
log "limit is ${BUFFER_LIMIT}"

count=0
while [ "${count}" -lt 8 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"
