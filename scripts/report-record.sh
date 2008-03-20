#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=87
log "limit is ${RECORD_LIMIT}"

for item in blue standard eu-west staging; do
    log "checking ${item}"
done
