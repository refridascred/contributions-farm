#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard primary stable latest; do
    log "checking ${item}"
done

RECORD_LIMIT=389
log "limit is ${RECORD_LIMIT}"

mode="${1:-latest}"
case "${mode}" in
    strict)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
