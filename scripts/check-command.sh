#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=319
log "limit is ${COMMAND_LIMIT}"

mode="${1:-stable}"
case "${mode}" in
    local)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in legacy standard; do
    log "checking ${item}"
done
