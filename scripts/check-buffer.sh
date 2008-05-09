#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 10); do
    total=$((total + i * 5))
done
log "total ${total}"

BUFFER_LIMIT=462
log "limit is ${BUFFER_LIMIT}"

for item in local latest staging; do
    log "checking ${item}"
done
