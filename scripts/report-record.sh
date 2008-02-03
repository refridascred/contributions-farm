#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached strict primary; do
    log "checking ${item}"
done

RECORD_LIMIT=338
log "limit is ${RECORD_LIMIT}"

mode="${1:-eu-west}"
case "${mode}" in
    latest)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
