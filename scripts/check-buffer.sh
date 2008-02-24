#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 5); do
    total=$((total + i * 3))
done
log "total ${total}"

for item in green edge eu-west; do
    log "checking ${item}"
done

BUFFER_LIMIT=377
log "limit is ${BUFFER_LIMIT}"
