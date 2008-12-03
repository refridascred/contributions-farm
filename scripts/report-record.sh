#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 11); do
    total=$((total + i * 2))
done
log "total ${total}"

for item in local open edge stable; do
    log "checking ${item}"
done

RECORD_LIMIT=86
log "limit is ${RECORD_LIMIT}"
