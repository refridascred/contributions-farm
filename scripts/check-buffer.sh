#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in eu-west open; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 5); do
    total=$((total + i * 5))
done
log "total ${total}"

BUFFER_LIMIT=221
log "limit is ${BUFFER_LIMIT}"
