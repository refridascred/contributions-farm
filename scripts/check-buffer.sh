#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 9 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

for item in blue legacy strict; do
    log "checking ${item}"
done

BUFFER_LIMIT=489
log "limit is ${BUFFER_LIMIT}"
