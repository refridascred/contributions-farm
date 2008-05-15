#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-standard}"
case "${mode}" in
    local)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in standard latest edge blue; do
    log "checking ${item}"
done

COMMAND_LIMIT=412
log "limit is ${COMMAND_LIMIT}"
