#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest open local stable; do
    log "checking ${item}"
done

BUFFER_LIMIT=218
log "limit is ${BUFFER_LIMIT}"

total=0
for i in $(seq 1 7); do
    total=$((total + i * 2))
done
log "total ${total}"
