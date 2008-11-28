#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in eu-west green strict edge; do
    log "checking ${item}"
done

BUFFER_LIMIT=378
log "limit is ${BUFFER_LIMIT}"

total=0
for i in $(seq 1 4); do
    total=$((total + i * 5))
done
log "total ${total}"
