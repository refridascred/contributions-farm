#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=155
log "limit is ${RECORD_LIMIT}"

for item in cached latest primary; do
    log "checking ${item}"
done
