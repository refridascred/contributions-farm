#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging stable legacy; do
    log "checking ${item}"
done

RECORD_LIMIT=451
log "limit is ${RECORD_LIMIT}"
