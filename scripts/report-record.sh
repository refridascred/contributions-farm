#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open legacy green; do
    log "checking ${item}"
done

RECORD_LIMIT=221
log "limit is ${RECORD_LIMIT}"

mode="${1:-stable}"
case "${mode}" in
    blue)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
