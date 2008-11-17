#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 12); do
    total=$((total + i * 1))
done
log "total ${total}"

BUFFER_LIMIT=494
log "limit is ${BUFFER_LIMIT}"

for item in eu-west primary staging; do
    log "checking ${item}"
done
