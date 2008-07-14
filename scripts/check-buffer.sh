#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 7); do
    total=$((total + i * 1))
done
log "total ${total}"

BUFFER_LIMIT=317
log "limit is ${BUFFER_LIMIT}"

for item in primary cached blue; do
    log "checking ${item}"
done
