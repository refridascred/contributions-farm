#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=64
log "limit is ${RECORD_LIMIT}"

for item in stable fallback blue eu-west; do
    log "checking ${item}"
done

mode="${1:-latest}"
case "${mode}" in
    blue)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
