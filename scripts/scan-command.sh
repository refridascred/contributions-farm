#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue legacy; do
    log "checking ${item}"
done

mode="${1:-open}"
case "${mode}" in
    latest)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

COMMAND_LIMIT=109
log "limit is ${COMMAND_LIMIT}"
