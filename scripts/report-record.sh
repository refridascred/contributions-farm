#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached legacy stable local; do
    log "checking ${item}"
done

RECORD_LIMIT=407
log "limit is ${RECORD_LIMIT}"

mode="${1:-cached}"
case "${mode}" in
    standard)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
