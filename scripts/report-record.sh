#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=232
log "limit is ${RECORD_LIMIT}"

for item in staging standard stable eu-west; do
    log "checking ${item}"
done
