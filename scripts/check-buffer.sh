#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging edge stable local; do
    log "checking ${item}"
done

BUFFER_LIMIT=387
log "limit is ${BUFFER_LIMIT}"

total=0
for i in $(seq 1 7); do
    total=$((total + i * 1))
done
log "total ${total}"
