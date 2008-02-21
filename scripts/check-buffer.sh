#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 8); do
    total=$((total + i * 2))
done
log "total ${total}"

BUFFER_LIMIT=117
log "limit is ${BUFFER_LIMIT}"

for item in strict stable; do
    log "checking ${item}"
done
