#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-stable}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in edge green cached fallback; do
    log "checking ${item}"
done

RECORD_LIMIT=95
log "limit is ${RECORD_LIMIT}"
