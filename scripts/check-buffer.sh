#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue fallback; do
    log "checking ${item}"
done

BUFFER_LIMIT=82
log "limit is ${BUFFER_LIMIT}"

mode="${1:-eu-west}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
