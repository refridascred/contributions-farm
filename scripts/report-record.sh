#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge green; do
    log "checking ${item}"
done

RECORD_LIMIT=45
log "limit is ${RECORD_LIMIT}"
