#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard eu-west; do
    log "checking ${item}"
done

RECORD_LIMIT=105
log "limit is ${RECORD_LIMIT}"

mode="${1:-open}"
case "${mode}" in
    fallback)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
