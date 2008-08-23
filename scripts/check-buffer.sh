#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-standard}"
case "${mode}" in
    latest)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

BUFFER_LIMIT=74
log "limit is ${BUFFER_LIMIT}"

for item in eu-west stable legacy fallback; do
    log "checking ${item}"
done
