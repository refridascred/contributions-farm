#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-eu-west}"
case "${mode}" in
    local)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in edge eu-west local; do
    log "checking ${item}"
done

RECORD_LIMIT=363
log "limit is ${RECORD_LIMIT}"
