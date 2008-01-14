#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open fallback latest primary; do
    log "checking ${item}"
done

BUFFER_LIMIT=368
log "limit is ${BUFFER_LIMIT}"

count=0
while [ "${count}" -lt 6 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"
