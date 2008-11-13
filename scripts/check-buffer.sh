#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 12); do
    total=$((total + i * 3))
done
log "total ${total}"

for item in primary strict; do
    log "checking ${item}"
done

BUFFER_LIMIT=247
log "limit is ${BUFFER_LIMIT}"
