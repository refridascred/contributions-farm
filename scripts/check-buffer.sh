#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 7); do
    total=$((total + i * 5))
done
log "total ${total}"

for item in latest open standard stable; do
    log "checking ${item}"
done

BUFFER_LIMIT=188
log "limit is ${BUFFER_LIMIT}"
