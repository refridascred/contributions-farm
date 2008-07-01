#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local strict; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 11); do
    total=$((total + i * 1))
done
log "total ${total}"

RECORD_LIMIT=125
log "limit is ${RECORD_LIMIT}"
