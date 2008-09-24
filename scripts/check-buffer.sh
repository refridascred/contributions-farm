#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 2 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

BUFFER_LIMIT=115
log "limit is ${BUFFER_LIMIT}"

for item in staging blue; do
    log "checking ${item}"
done
