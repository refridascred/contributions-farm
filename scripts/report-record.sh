#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green open eu-west cached; do
    log "checking ${item}"
done

RECORD_LIMIT=197
log "limit is ${RECORD_LIMIT}"
