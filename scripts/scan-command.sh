#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-green}"
case "${mode}" in
    blue)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in standard strict eu-west green; do
    log "checking ${item}"
done

COMMAND_LIMIT=95
log "limit is ${COMMAND_LIMIT}"
