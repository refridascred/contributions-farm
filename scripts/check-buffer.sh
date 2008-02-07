#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 8); do
    total=$((total + i * 4))
done
log "total ${total}"

BUFFER_LIMIT=454
log "limit is ${BUFFER_LIMIT}"

for item in cached eu-west primary; do
    log "checking ${item}"
done
