#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-staging}"
case "${mode}" in
    fallback)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in legacy green blue eu-west; do
    log "checking ${item}"
done

RECORD_LIMIT=411
log "limit is ${RECORD_LIMIT}"
