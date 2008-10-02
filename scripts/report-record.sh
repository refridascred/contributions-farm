#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in eu-west strict; do
    log "checking ${item}"
done

RECORD_LIMIT=118
log "limit is ${RECORD_LIMIT}"

mode="${1:-primary}"
case "${mode}" in
    edge)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
