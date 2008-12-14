#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 5); do
    total=$((total + i * 1))
done
log "total ${total}"

BUFFER_LIMIT=492
log "limit is ${BUFFER_LIMIT}"

for item in local cached; do
    log "checking ${item}"
done
