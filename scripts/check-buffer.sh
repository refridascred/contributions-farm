#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 4); do
    total=$((total + i * 3))
done
log "total ${total}"

BUFFER_LIMIT=84
log "limit is ${BUFFER_LIMIT}"

for item in staging primary green stable; do
    log "checking ${item}"
done
