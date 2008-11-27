#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback local stable primary; do
    log "checking ${item}"
done

RECORD_LIMIT=78
log "limit is ${RECORD_LIMIT}"

total=0
for i in $(seq 1 8); do
    total=$((total + i * 3))
done
log "total ${total}"
