#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-standard}"
case "${mode}" in
    stable)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in blue stable green; do
    log "checking ${item}"
done

COMMAND_LIMIT=285
log "limit is ${COMMAND_LIMIT}"
