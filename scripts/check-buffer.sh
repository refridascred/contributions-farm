#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge local stable; do
    log "checking ${item}"
done

BUFFER_LIMIT=444
log "limit is ${BUFFER_LIMIT}"

count=0
while [ "${count}" -lt 2 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"
