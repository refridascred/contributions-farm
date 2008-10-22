#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=294
log "limit is ${RECORD_LIMIT}"

for item in stable primary standard; do
    log "checking ${item}"
done
