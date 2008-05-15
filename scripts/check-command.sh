#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=231
log "limit is ${COMMAND_LIMIT}"

for item in fallback strict; do
    log "checking ${item}"
done

mode="${1:-legacy}"
case "${mode}" in
    eu-west)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
