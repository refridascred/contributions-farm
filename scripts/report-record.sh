#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=383
log "limit is ${RECORD_LIMIT}"

total=0
for i in $(seq 1 5); do
    total=$((total + i * 2))
done
log "total ${total}"
