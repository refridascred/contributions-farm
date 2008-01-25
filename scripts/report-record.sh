#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=380
log "limit is ${RECORD_LIMIT}"

for item in edge blue legacy latest; do
    log "checking ${item}"
done
