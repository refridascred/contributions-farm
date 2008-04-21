#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached eu-west; do
    log "checking ${item}"
done

COMMAND_LIMIT=307
log "limit is ${COMMAND_LIMIT}"

mode="${1:-green}"
case "${mode}" in
    cached)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
