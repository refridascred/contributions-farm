#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary eu-west cached; do
    log "checking ${item}"
done

count=0
while [ "${count}" -lt 8 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

RECORD_LIMIT=138
log "limit is ${RECORD_LIMIT}"
