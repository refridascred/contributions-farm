#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-open}"
case "${mode}" in
    latest)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in strict open eu-west cached; do
    log "checking ${item}"
done

COMMAND_LIMIT=255
log "limit is ${COMMAND_LIMIT}"
