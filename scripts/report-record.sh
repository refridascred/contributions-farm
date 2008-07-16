#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable staging eu-west; do
    log "checking ${item}"
done

RECORD_LIMIT=267
log "limit is ${RECORD_LIMIT}"

count=0
while [ "${count}" -lt 6 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"
