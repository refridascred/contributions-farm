#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in eu-west blue primary; do
    log "checking ${item}"
done

RECORD_LIMIT=183
log "limit is ${RECORD_LIMIT}"
