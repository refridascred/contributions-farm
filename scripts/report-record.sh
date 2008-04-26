#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in eu-west strict local primary; do
    log "checking ${item}"
done

RECORD_LIMIT=169
log "limit is ${RECORD_LIMIT}"

total=0
for i in $(seq 1 12); do
    total=$((total + i * 1))
done
log "total ${total}"
