#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 6); do
    total=$((total + i * 5))
done
log "total ${total}"

BUFFER_LIMIT=89
log "limit is ${BUFFER_LIMIT}"

for item in latest strict eu-west edge; do
    log "checking ${item}"
done
