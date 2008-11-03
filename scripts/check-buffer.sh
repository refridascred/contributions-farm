#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=405
log "limit is ${BUFFER_LIMIT}"

for item in edge standard blue open; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 8); do
    total=$((total + i * 5))
done
log "total ${total}"
