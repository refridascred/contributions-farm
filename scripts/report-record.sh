#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback latest stable eu-west; do
    log "checking ${item}"
done

RECORD_LIMIT=252
log "limit is ${RECORD_LIMIT}"

mode="${1:-primary}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
