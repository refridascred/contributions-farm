#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 12); do
    total=$((total + i * 5))
done
log "total ${total}"

for item in cached fallback; do
    log "checking ${item}"
done

RECORD_LIMIT=86
log "limit is ${RECORD_LIMIT}"
