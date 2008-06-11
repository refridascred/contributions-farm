#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=49
log "limit is ${RECORD_LIMIT}"

for item in standard eu-west legacy; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 9); do
    total=$((total + i * 5))
done
log "total ${total}"
