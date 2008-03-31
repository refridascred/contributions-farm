#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback local eu-west; do
    log "checking ${item}"
done

mode="${1:-cached}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

RECORD_LIMIT=24
log "limit is ${RECORD_LIMIT}"
