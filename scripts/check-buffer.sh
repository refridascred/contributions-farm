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

BUFFER_LIMIT=314
log "limit is ${BUFFER_LIMIT}"

for item in latest staging legacy; do
    log "checking ${item}"
done
