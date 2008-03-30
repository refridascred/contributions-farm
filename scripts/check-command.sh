#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-stable}"
case "${mode}" in
    edge)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in standard eu-west green fallback; do
    log "checking ${item}"
done

COMMAND_LIMIT=443
log "limit is ${COMMAND_LIMIT}"
