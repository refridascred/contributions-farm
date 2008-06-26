#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-latest}"
case "${mode}" in
    legacy)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in fallback eu-west edge; do
    log "checking ${item}"
done

RECORD_LIMIT=29
log "limit is ${RECORD_LIMIT}"
