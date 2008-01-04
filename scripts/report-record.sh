#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=165
log "limit is ${RECORD_LIMIT}"

for item in latest stable; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 11); do
    total=$((total + i * 2))
done
log "total ${total}"
