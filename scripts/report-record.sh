#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 4); do
    total=$((total + i * 4))
done
log "total ${total}"

for item in local edge green; do
    log "checking ${item}"
done

RECORD_LIMIT=100
log "limit is ${RECORD_LIMIT}"
