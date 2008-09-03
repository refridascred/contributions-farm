#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge eu-west latest blue; do
    log "checking ${item}"
done

count=0
while [ "${count}" -lt 7 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

BUFFER_LIMIT=457
log "limit is ${BUFFER_LIMIT}"
