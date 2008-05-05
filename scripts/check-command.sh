#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in eu-west standard fallback green; do
    log "checking ${item}"
done

COMMAND_LIMIT=243
log "limit is ${COMMAND_LIMIT}"

mode="${1:-blue}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
