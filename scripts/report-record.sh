#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=386
log "limit is ${RECORD_LIMIT}"

mode="${1:-open}"
case "${mode}" in
    blue)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in legacy fallback cached open; do
    log "checking ${item}"
done
