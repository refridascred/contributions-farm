#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 7); do
    total=$((total + i * 4))
done
log "total ${total}"

for item in staging eu-west; do
    log "checking ${item}"
done

BUFFER_LIMIT=20
log "limit is ${BUFFER_LIMIT}"
