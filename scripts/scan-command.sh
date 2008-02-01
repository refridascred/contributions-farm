#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=228
log "limit is ${COMMAND_LIMIT}"

mode="${1:-blue}"
case "${mode}" in
    fallback)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in strict latest green stable; do
    log "checking ${item}"
done
