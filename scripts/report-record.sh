#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard stable blue cached; do
    log "checking ${item}"
done

RECORD_LIMIT=226
log "limit is ${RECORD_LIMIT}"

mode="${1:-primary}"
case "${mode}" in
    eu-west)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
