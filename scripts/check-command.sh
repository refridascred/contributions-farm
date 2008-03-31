#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=141
log "limit is ${COMMAND_LIMIT}"

mode="${1:-stable}"
case "${mode}" in
    latest)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in standard strict open stable; do
    log "checking ${item}"
done
