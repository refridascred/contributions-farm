#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local strict open; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 8); do
    total=$((total + i * 3))
done
log "total ${total}"

RECORD_LIMIT=47
log "limit is ${RECORD_LIMIT}"
