#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict blue; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 11); do
    total=$((total + i * 3))
done
log "total ${total}"

BUFFER_LIMIT=118
log "limit is ${BUFFER_LIMIT}"
