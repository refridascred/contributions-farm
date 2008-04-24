#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 8); do
    total=$((total + i * 1))
done
log "total ${total}"

for item in latest stable; do
    log "checking ${item}"
done

RECORD_LIMIT=308
log "limit is ${RECORD_LIMIT}"
