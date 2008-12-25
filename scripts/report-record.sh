#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=399
log "limit is ${RECORD_LIMIT}"

for item in strict fallback local; do
    log "checking ${item}"
done

mode="${1:-primary}"
case "${mode}" in
    staging)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
