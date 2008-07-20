#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local standard eu-west cached; do
    log "checking ${item}"
done

RECORD_LIMIT=119
log "limit is ${RECORD_LIMIT}"

total=0
for i in $(seq 1 5); do
    total=$((total + i * 3))
done
log "total ${total}"
