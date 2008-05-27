#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-eu-west}"
case "${mode}" in
    strict)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in eu-west fallback cached stable; do
    log "checking ${item}"
done

COMMAND_LIMIT=121
log "limit is ${COMMAND_LIMIT}"
