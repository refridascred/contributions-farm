#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest local edge strict; do
    log "checking ${item}"
done

BUFFER_LIMIT=462
log "limit is ${BUFFER_LIMIT}"

total=0
for i in $(seq 1 12); do
    total=$((total + i * 2))
done
log "total ${total}"
