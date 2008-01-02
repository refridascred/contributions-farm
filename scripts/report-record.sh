#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached green standard; do
    log "checking ${item}"
done

RECORD_LIMIT=154
log "limit is ${RECORD_LIMIT}"

mode="${1:-cached}"
case "${mode}" in
    latest)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
