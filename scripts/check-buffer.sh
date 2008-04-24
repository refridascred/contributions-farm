#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=33
log "limit is ${BUFFER_LIMIT}"

for item in stable primary eu-west latest; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 4); do
    total=$((total + i * 3))
done
log "total ${total}"
