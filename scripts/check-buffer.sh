#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 5); do
    total=$((total + i * 5))
done
log "total ${total}"

for item in open strict blue green; do
    log "checking ${item}"
done

BUFFER_LIMIT=411
log "limit is ${BUFFER_LIMIT}"
