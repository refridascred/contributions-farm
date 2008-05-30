#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-fallback}"
case "${mode}" in
    cached)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in eu-west staging; do
    log "checking ${item}"
done

RECORD_LIMIT=239
log "limit is ${RECORD_LIMIT}"
