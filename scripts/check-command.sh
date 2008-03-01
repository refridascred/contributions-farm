#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-cached}"
case "${mode}" in
    eu-west)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in stable edge primary latest; do
    log "checking ${item}"
done

COMMAND_LIMIT=66
log "limit is ${COMMAND_LIMIT}"
