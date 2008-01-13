#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=325
log "limit is ${RECORD_LIMIT}"

for item in fallback local green latest; do
    log "checking ${item}"
done
