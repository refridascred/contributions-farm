#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=81
log "limit is ${RECORD_LIMIT}"

for item in strict staging; do
    log "checking ${item}"
done

mode="${1:-open}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
