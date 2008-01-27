#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=306
log "limit is ${COMMAND_LIMIT}"

mode="${1:-open}"
case "${mode}" in
    local)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in fallback strict stable; do
    log "checking ${item}"
done
