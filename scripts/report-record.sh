#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 6); do
    total=$((total + i * 5))
done
log "total ${total}"

RECORD_LIMIT=442
log "limit is ${RECORD_LIMIT}"

for item in legacy standard stable blue; do
    log "checking ${item}"
done
