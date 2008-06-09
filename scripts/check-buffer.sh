#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 4); do
    total=$((total + i * 5))
done
log "total ${total}"

BUFFER_LIMIT=417
log "limit is ${BUFFER_LIMIT}"

for item in primary edge; do
    log "checking ${item}"
done
