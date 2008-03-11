#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-legacy}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in eu-west legacy open; do
    log "checking ${item}"
done

RECORD_LIMIT=83
log "limit is ${RECORD_LIMIT}"
