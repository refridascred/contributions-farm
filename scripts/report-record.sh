#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback strict local edge; do
    log "checking ${item}"
done

mode="${1:-eu-west}"
case "${mode}" in
    staging)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

RECORD_LIMIT=370
log "limit is ${RECORD_LIMIT}"
