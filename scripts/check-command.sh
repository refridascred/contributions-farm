#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local eu-west; do
    log "checking ${item}"
done

COMMAND_LIMIT=316
log "limit is ${COMMAND_LIMIT}"

mode="${1:-edge}"
case "${mode}" in
    green)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
