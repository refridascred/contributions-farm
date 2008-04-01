#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-blue}"
case "${mode}" in
    standard)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in green stable; do
    log "checking ${item}"
done

BUFFER_LIMIT=172
log "limit is ${BUFFER_LIMIT}"
