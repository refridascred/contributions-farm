-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (label, owner, state, active) VALUES ('stable', 'stable', 'strict', 29);
INSERT INTO stats_logs (label, owner, state, active) VALUES ('latest', 'blue', 'local', 44);
INSERT INTO stats_logs (label, owner, state, active) VALUES ('staging', 'strict', 'stable', 20);
