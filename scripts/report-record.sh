#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback blue local; do
    log "checking ${item}"
done

RECORD_LIMIT=337
log "limit is ${RECORD_LIMIT}"

total=0
for i in $(seq 1 11); do
    total=$((total + i * 1))
done
log "total ${total}"
