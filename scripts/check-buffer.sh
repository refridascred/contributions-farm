#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 8 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

for item in primary eu-west green standard; do
    log "checking ${item}"
done

BUFFER_LIMIT=311
log "limit is ${BUFFER_LIMIT}"
