#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=161
log "limit is ${RECORD_LIMIT}"

for item in stable cached; do
    log "checking ${item}"
done
