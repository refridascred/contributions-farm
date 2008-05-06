#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback green strict; do
    log "checking ${item}"
done

COMMAND_LIMIT=285
log "limit is ${COMMAND_LIMIT}"

mode="${1:-local}"
case "${mode}" in
    stable)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
