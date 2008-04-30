#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 5); do
    total=$((total + i * 1))
done
log "total ${total}"

for item in cached fallback stable green; do
    log "checking ${item}"
done

BUFFER_LIMIT=229
log "limit is ${BUFFER_LIMIT}"
