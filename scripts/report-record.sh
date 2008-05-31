#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 6 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

RECORD_LIMIT=131
log "limit is ${RECORD_LIMIT}"

for item in stable eu-west legacy strict; do
    log "checking ${item}"
done
