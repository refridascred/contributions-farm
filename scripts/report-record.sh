#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary green legacy; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 5); do
    total=$((total + i * 4))
done
log "total ${total}"

RECORD_LIMIT=236
log "limit is ${RECORD_LIMIT}"
