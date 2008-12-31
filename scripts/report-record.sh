#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 10); do
    total=$((total + i * 2))
done
log "total ${total}"

for item in primary staging cached stable; do
    log "checking ${item}"
done

RECORD_LIMIT=74
log "limit is ${RECORD_LIMIT}"
