#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 8); do
    total=$((total + i * 3))
done
log "total ${total}"

for item in legacy strict green edge; do
    log "checking ${item}"
done

BUFFER_LIMIT=102
log "limit is ${BUFFER_LIMIT}"
