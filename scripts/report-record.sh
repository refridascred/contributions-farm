#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=197
log "limit is ${RECORD_LIMIT}"

for item in standard eu-west cached; do
    log "checking ${item}"
done
