#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local open legacy latest; do
    log "checking ${item}"
done

BUFFER_LIMIT=132
log "limit is ${BUFFER_LIMIT}"

mode="${1:-latest}"
case "${mode}" in
    eu-west)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
