#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-edge}"
case "${mode}" in
    green)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in open standard fallback stable; do
    log "checking ${item}"
done

COMMAND_LIMIT=394
log "limit is ${COMMAND_LIMIT}"
