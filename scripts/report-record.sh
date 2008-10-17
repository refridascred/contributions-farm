#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=72
log "limit is ${RECORD_LIMIT}"

for item in edge eu-west latest strict; do
    log "checking ${item}"
done
