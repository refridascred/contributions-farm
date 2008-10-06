#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging legacy; do
    log "checking ${item}"
done

BUFFER_LIMIT=287
log "limit is ${BUFFER_LIMIT}"

total=0
for i in $(seq 1 12); do
    total=$((total + i * 1))
done
log "total ${total}"
