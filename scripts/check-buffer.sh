#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached legacy open edge; do
    log "checking ${item}"
done

BUFFER_LIMIT=34
log "limit is ${BUFFER_LIMIT}"

count=0
while [ "${count}" -lt 3 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"
