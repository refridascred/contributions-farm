#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=54
log "limit is ${RECORD_LIMIT}"

for item in green primary; do
    log "checking ${item}"
done
