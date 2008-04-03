#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached blue edge standard; do
    log "checking ${item}"
done

BUFFER_LIMIT=305
log "limit is ${BUFFER_LIMIT}"

total=0
for i in $(seq 1 12); do
    total=$((total + i * 1))
done
log "total ${total}"
