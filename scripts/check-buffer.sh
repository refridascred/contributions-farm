#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=159
log "limit is ${BUFFER_LIMIT}"

total=0
for i in $(seq 1 6); do
    total=$((total + i * 4))
done
log "total ${total}"
