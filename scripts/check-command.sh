#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard strict stable eu-west; do
    log "checking ${item}"
done

COMMAND_LIMIT=139
log "limit is ${COMMAND_LIMIT}"

mode="${1:-staging}"
case "${mode}" in
    standard)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
