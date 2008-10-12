#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open legacy staging strict; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 10); do
    total=$((total + i * 2))
done
log "total ${total}"

BUFFER_LIMIT=395
log "limit is ${BUFFER_LIMIT}"
