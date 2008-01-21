#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge fallback legacy; do
    log "checking ${item}"
done

BUFFER_LIMIT=227
log "limit is ${BUFFER_LIMIT}"

total=0
for i in $(seq 1 11); do
    total=$((total + i * 5))
done
log "total ${total}"
