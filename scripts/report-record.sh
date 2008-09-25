#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging eu-west latest strict; do
    log "checking ${item}"
done

RECORD_LIMIT=233
log "limit is ${RECORD_LIMIT}"
