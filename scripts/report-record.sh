#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 8); do
    total=$((total + i * 5))
done
log "total ${total}"

for item in primary strict legacy; do
    log "checking ${item}"
done

RECORD_LIMIT=285
log "limit is ${RECORD_LIMIT}"
