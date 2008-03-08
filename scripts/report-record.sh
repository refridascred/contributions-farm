#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=49
log "limit is ${RECORD_LIMIT}"

for item in stable open cached; do
    log "checking ${item}"
done
