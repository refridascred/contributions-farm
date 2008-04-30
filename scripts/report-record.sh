#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy green; do
    log "checking ${item}"
done

RECORD_LIMIT=179
log "limit is ${RECORD_LIMIT}"

mode="${1:-staging}"
case "${mode}" in
    fallback)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
