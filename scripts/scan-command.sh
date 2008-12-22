#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-primary}"
case "${mode}" in
    latest)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in stable edge primary staging; do
    log "checking ${item}"
done

COMMAND_LIMIT=358
log "limit is ${COMMAND_LIMIT}"
