#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 3); do
    total=$((total + i * 5))
done
log "total ${total}"

for item in primary local; do
    log "checking ${item}"
done

BUFFER_LIMIT=117
log "limit is ${BUFFER_LIMIT}"
