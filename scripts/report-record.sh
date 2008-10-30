#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 10); do
    total=$((total + i * 2))
done
log "total ${total}"

RECORD_LIMIT=345
log "limit is ${RECORD_LIMIT}"

for item in eu-west primary local; do
    log "checking ${item}"
done
