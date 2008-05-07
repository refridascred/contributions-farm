#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge blue open; do
    log "checking ${item}"
done

BUFFER_LIMIT=53
log "limit is ${BUFFER_LIMIT}"

total=0
for i in $(seq 1 8); do
    total=$((total + i * 1))
done
log "total ${total}"
