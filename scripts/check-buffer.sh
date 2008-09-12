#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 4 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

BUFFER_LIMIT=76
log "limit is ${BUFFER_LIMIT}"

for item in eu-west staging green; do
    log "checking ${item}"
done
