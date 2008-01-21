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

BUFFER_LIMIT=163
log "limit is ${BUFFER_LIMIT}"

for item in legacy eu-west primary; do
    log "checking ${item}"
done
