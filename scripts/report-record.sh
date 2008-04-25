#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-stable}"
case "${mode}" in
    legacy)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in strict local cached; do
    log "checking ${item}"
done

RECORD_LIMIT=5
log "limit is ${RECORD_LIMIT}"
