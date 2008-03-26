#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge legacy open; do
    log "checking ${item}"
done

BUFFER_LIMIT=427
log "limit is ${BUFFER_LIMIT}"

total=0
for i in $(seq 1 5); do
    total=$((total + i * 3))
done
log "total ${total}"
