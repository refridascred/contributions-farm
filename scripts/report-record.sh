#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local edge strict staging; do
    log "checking ${item}"
done

RECORD_LIMIT=56
log "limit is ${RECORD_LIMIT}"

total=0
for i in $(seq 1 7); do
    total=$((total + i * 3))
done
log "total ${total}"
