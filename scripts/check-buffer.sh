#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 6 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

for item in blue edge fallback eu-west; do
    log "checking ${item}"
done

BUFFER_LIMIT=159
log "limit is ${BUFFER_LIMIT}"
