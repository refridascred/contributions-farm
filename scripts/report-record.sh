#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open strict; do
    log "checking ${item}"
done

RECORD_LIMIT=25
log "limit is ${RECORD_LIMIT}"

mode="${1:-local}"
case "${mode}" in
    local)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
