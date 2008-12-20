#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging open latest; do
    log "checking ${item}"
done

RECORD_LIMIT=131
log "limit is ${RECORD_LIMIT}"
