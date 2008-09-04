#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=343
log "limit is ${RECORD_LIMIT}"

for item in staging local primary; do
    log "checking ${item}"
done

mode="${1:-legacy}"
case "${mode}" in
    cached)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
