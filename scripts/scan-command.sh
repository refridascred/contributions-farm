#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard strict latest; do
    log "checking ${item}"
done

mode="${1:-fallback}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

COMMAND_LIMIT=121
log "limit is ${COMMAND_LIMIT}"
