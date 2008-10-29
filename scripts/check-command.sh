#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue legacy latest; do
    log "checking ${item}"
done

COMMAND_LIMIT=23
log "limit is ${COMMAND_LIMIT}"

mode="${1:-primary}"
case "${mode}" in
    legacy)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
