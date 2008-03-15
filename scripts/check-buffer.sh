#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 2 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

for item in open staging stable eu-west; do
    log "checking ${item}"
done

BUFFER_LIMIT=443
log "limit is ${BUFFER_LIMIT}"
