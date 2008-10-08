#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict open staging; do
    log "checking ${item}"
done

BUFFER_LIMIT=444
log "limit is ${BUFFER_LIMIT}"

total=0
for i in $(seq 1 6); do
    total=$((total + i * 2))
done
log "total ${total}"
