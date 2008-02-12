#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green local blue fallback; do
    log "checking ${item}"
done

BUFFER_LIMIT=18
log "limit is ${BUFFER_LIMIT}"

count=0
while [ "${count}" -lt 7 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"
