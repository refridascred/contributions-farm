#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-green}"
case "${mode}" in
    cached)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

RECORD_LIMIT=243
log "limit is ${RECORD_LIMIT}"

for item in staging cached stable latest; do
    log "checking ${item}"
done
