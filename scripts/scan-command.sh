#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached standard; do
    log "checking ${item}"
done

mode="${1:-fallback}"
case "${mode}" in
    green)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

COMMAND_LIMIT=327
log "limit is ${COMMAND_LIMIT}"
