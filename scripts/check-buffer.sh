#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 9); do
    total=$((total + i * 1))
done
log "total ${total}"

for item in blue local legacy; do
    log "checking ${item}"
done

BUFFER_LIMIT=32
log "limit is ${BUFFER_LIMIT}"
