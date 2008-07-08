#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=202
log "limit is ${RECORD_LIMIT}"

for item in standard eu-west staging cached; do
    log "checking ${item}"
done
