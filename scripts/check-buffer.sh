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

for item in cached local strict eu-west; do
    log "checking ${item}"
done

BUFFER_LIMIT=373
log "limit is ${BUFFER_LIMIT}"
