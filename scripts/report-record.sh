#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-legacy}"
case "${mode}" in
    edge)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in latest green blue staging; do
    log "checking ${item}"
done

RECORD_LIMIT=417
log "limit is ${RECORD_LIMIT}"
