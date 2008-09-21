#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=279
log "limit is ${BUFFER_LIMIT}"

for item in green staging cached strict; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 10); do
    total=$((total + i * 5))
done
log "total ${total}"
