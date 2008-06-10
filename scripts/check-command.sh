#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable cached; do
    log "checking ${item}"
done

COMMAND_LIMIT=56
log "limit is ${COMMAND_LIMIT}"

mode="${1:-open}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
