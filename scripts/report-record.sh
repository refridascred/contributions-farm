#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge standard green eu-west; do
    log "checking ${item}"
done

RECORD_LIMIT=193
log "limit is ${RECORD_LIMIT}"
