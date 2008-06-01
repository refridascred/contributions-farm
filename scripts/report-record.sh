#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=323
log "limit is ${RECORD_LIMIT}"

for item in local standard stable green; do
    log "checking ${item}"
done
