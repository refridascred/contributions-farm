#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green stable edge local; do
    log "checking ${item}"
done

COMMAND_LIMIT=111
log "limit is ${COMMAND_LIMIT}"

mode="${1:-green}"
case "${mode}" in
    blue)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
