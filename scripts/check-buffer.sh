#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=300
log "limit is ${BUFFER_LIMIT}"

for item in open latest blue; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 9); do
    total=$((total + i * 4))
done
log "total ${total}"
