#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=229
log "limit is ${COMMAND_LIMIT}"

mode="${1:-legacy}"
case "${mode}" in
    strict)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in green staging strict blue; do
    log "checking ${item}"
done
