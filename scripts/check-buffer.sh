#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=180
log "limit is ${BUFFER_LIMIT}"

for item in blue green stable latest; do
    log "checking ${item}"
done

mode="${1:-stable}"
case "${mode}" in
    eu-west)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
