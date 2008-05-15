#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=245
log "limit is ${BUFFER_LIMIT}"

for item in edge latest blue cached; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 10); do
    total=$((total + i * 2))
done
log "total ${total}"
