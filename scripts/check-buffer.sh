#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest fallback; do
    log "checking ${item}"
done

count=0
while [ "${count}" -lt 9 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

BUFFER_LIMIT=435
log "limit is ${BUFFER_LIMIT}"
