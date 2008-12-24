#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-eu-west}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in local open green staging; do
    log "checking ${item}"
done

RECORD_LIMIT=338
log "limit is ${RECORD_LIMIT}"
