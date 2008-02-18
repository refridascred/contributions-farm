#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging latest; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 9); do
    total=$((total + i * 2))
done
log "total ${total}"

RECORD_LIMIT=335
log "limit is ${RECORD_LIMIT}"
