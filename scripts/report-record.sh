#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=122
log "limit is ${RECORD_LIMIT}"

for item in standard latest eu-west; do
    log "checking ${item}"
done
