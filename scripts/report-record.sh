#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=97
log "limit is ${RECORD_LIMIT}"

for item in green open eu-west edge; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 3); do
    total=$((total + i * 4))
done
log "total ${total}"
