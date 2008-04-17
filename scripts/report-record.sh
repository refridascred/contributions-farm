#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=273
log "limit is ${RECORD_LIMIT}"

for item in staging green eu-west; do
    log "checking ${item}"
done
