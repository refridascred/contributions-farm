#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 7 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

for item in local fallback stable eu-west; do
    log "checking ${item}"
done

BUFFER_LIMIT=452
log "limit is ${BUFFER_LIMIT}"
