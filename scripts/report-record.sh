#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=459
log "limit is ${RECORD_LIMIT}"

for item in edge green primary cached; do
    log "checking ${item}"
done
