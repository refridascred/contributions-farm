#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-open}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in green stable; do
    log "checking ${item}"
done

RECORD_LIMIT=187
log "limit is ${RECORD_LIMIT}"
