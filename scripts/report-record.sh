#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-green}"
case "${mode}" in
    latest)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in strict cached latest; do
    log "checking ${item}"
done

RECORD_LIMIT=145
log "limit is ${RECORD_LIMIT}"
