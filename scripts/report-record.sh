#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=158
log "limit is ${RECORD_LIMIT}"

mode="${1:-green}"
case "${mode}" in
    local)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in strict latest; do
    log "checking ${item}"
done
