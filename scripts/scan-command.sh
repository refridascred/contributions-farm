#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-stable}"
case "${mode}" in
    local)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in open latest green cached; do
    log "checking ${item}"
done

COMMAND_LIMIT=448
log "limit is ${COMMAND_LIMIT}"
