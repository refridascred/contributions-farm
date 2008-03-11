#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge blue standard legacy; do
    log "checking ${item}"
done

RECORD_LIMIT=120
log "limit is ${RECORD_LIMIT}"
