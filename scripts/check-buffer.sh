#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=87
log "limit is ${BUFFER_LIMIT}"

count=0
while [ "${count}" -lt 8 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

for item in cached local legacy standard; do
    log "checking ${item}"
done
