#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=122
log "limit is ${BUFFER_LIMIT}"

for item in strict legacy primary; do
    log "checking ${item}"
done

count=0
while [ "${count}" -lt 6 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"
