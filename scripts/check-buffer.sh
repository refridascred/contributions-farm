#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback primary green edge; do
    log "checking ${item}"
done

BUFFER_LIMIT=279
log "limit is ${BUFFER_LIMIT}"

total=0
for i in $(seq 1 3); do
    total=$((total + i * 2))
done
log "total ${total}"
