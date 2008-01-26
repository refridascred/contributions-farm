#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 2 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

RECORD_LIMIT=323
log "limit is ${RECORD_LIMIT}"

for item in staging strict fallback latest; do
    log "checking ${item}"
done
