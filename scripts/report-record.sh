#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary latest; do
    log "checking ${item}"
done

RECORD_LIMIT=358
log "limit is ${RECORD_LIMIT}"

total=0
for i in $(seq 1 11); do
    total=$((total + i * 1))
done
log "total ${total}"
