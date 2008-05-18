#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=483
log "limit is ${RECORD_LIMIT}"

for item in latest eu-west; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 5); do
    total=$((total + i * 4))
done
log "total ${total}"
