#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=291
log "limit is ${RECORD_LIMIT}"

for item in standard green; do
    log "checking ${item}"
done

mode="${1:-eu-west}"
case "${mode}" in
    cached)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
