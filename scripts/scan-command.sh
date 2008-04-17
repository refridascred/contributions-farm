#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-stable}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in fallback legacy green; do
    log "checking ${item}"
done

COMMAND_LIMIT=138
log "limit is ${COMMAND_LIMIT}"
