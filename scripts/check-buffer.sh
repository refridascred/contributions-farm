#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 3 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

BUFFER_LIMIT=211
log "limit is ${BUFFER_LIMIT}"

for item in legacy cached; do
    log "checking ${item}"
done
