#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy eu-west primary strict; do
    log "checking ${item}"
done

RECORD_LIMIT=379
log "limit is ${RECORD_LIMIT}"

mode="${1:-green}"
case "${mode}" in
    staging)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
