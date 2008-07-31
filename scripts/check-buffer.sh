#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue fallback edge eu-west; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 4); do
    total=$((total + i * 4))
done
log "total ${total}"

BUFFER_LIMIT=202
log "limit is ${BUFFER_LIMIT}"
