#!/usr/bin/env bash
# Check the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 6); do
    total=$((total + i * 2))
done
log "total ${total}"

for item in cached fallback; do
    log "checking ${item}"
done

RECORD_LIMIT=497
log "limit is ${RECORD_LIMIT}"
