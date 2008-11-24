#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=132
log "limit is ${COMMAND_LIMIT}"

mode="${1:-strict}"
case "${mode}" in
    local)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in green cached fallback stable; do
    log "checking ${item}"
done
