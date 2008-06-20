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

RECORD_LIMIT=20
log "limit is ${RECORD_LIMIT}"

for item in edge legacy eu-west blue; do
    log "checking ${item}"
done
