#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 5 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

for item in strict blue edge; do
    log "checking ${item}"
done

BUFFER_LIMIT=457
log "limit is ${BUFFER_LIMIT}"
