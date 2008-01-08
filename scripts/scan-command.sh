#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-stable}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in local blue staging; do
    log "checking ${item}"
done

COMMAND_LIMIT=274
log "limit is ${COMMAND_LIMIT}"
