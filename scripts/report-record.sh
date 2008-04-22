#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-primary}"
case "${mode}" in
    edge)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in eu-west primary standard; do
    log "checking ${item}"
done

RECORD_LIMIT=327
log "limit is ${RECORD_LIMIT}"
