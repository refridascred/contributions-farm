#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 9 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

RECORD_LIMIT=48
log "limit is ${RECORD_LIMIT}"

for item in staging green eu-west; do
    log "checking ${item}"
done
