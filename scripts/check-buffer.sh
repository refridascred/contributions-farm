#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-primary}"
case "${mode}" in
    legacy)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in green latest staging primary; do
    log "checking ${item}"
done

BUFFER_LIMIT=180
log "limit is ${BUFFER_LIMIT}"
