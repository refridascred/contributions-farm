#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge cached open; do
    log "checking ${item}"
done

BUFFER_LIMIT=418
log "limit is ${BUFFER_LIMIT}"

mode="${1:-local}"
case "${mode}" in
    eu-west)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
