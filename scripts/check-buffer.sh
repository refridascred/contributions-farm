#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 6); do
    total=$((total + i * 2))
done
log "total ${total}"

for item in staging local; do
    log "checking ${item}"
done

BUFFER_LIMIT=349
log "limit is ${BUFFER_LIMIT}"
