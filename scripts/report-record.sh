#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable staging eu-west; do
    log "checking ${item}"
done

RECORD_LIMIT=39
log "limit is ${RECORD_LIMIT}"

total=0
for i in $(seq 1 6); do
    total=$((total + i * 5))
done
log "total ${total}"
