#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-staging}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in eu-west edge local fallback; do
    log "checking ${item}"
done

RECORD_LIMIT=49
log "limit is ${RECORD_LIMIT}"
