#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=396
log "limit is ${BUFFER_LIMIT}"

for item in eu-west blue latest; do
    log "checking ${item}"
done

mode="${1:-cached}"
case "${mode}" in
    eu-west)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
