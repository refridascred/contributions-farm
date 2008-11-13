#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=432
log "limit is ${COMMAND_LIMIT}"

mode="${1:-edge}"
case "${mode}" in
    stable)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in blue staging cached green; do
    log "checking ${item}"
done
