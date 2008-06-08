#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=432
log "limit is ${RECORD_LIMIT}"

for item in standard open primary strict; do
    log "checking ${item}"
done
