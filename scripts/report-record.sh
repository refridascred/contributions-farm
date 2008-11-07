#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging edge; do
    log "checking ${item}"
done

RECORD_LIMIT=426
log "limit is ${RECORD_LIMIT}"

total=0
for i in $(seq 1 4); do
    total=$((total + i * 4))
done
log "total ${total}"
