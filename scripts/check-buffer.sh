#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard local; do
    log "checking ${item}"
done

BUFFER_LIMIT=218
log "limit is ${BUFFER_LIMIT}"

total=0
for i in $(seq 1 3); do
    total=$((total + i * 1))
done
log "total ${total}"
