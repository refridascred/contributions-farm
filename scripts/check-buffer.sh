#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard blue eu-west staging; do
    log "checking ${item}"
done

BUFFER_LIMIT=89
log "limit is ${BUFFER_LIMIT}"

count=0
while [ "${count}" -lt 9 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"
