#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback blue green; do
    log "checking ${item}"
done

COMMAND_LIMIT=444
log "limit is ${COMMAND_LIMIT}"

mode="${1:-open}"
case "${mode}" in
    green)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
