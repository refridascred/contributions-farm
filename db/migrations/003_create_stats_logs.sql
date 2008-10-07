-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, owner, rank, active, state) VALUES ('staging', 'standard', 14, 15, 'green');
INSERT INTO stats_logs (label, owner, rank, active, state) VALUES ('stable', 'eu-west', 39, 79, 'fallback');
INSERT INTO stats_logs (label, owner, rank, active, state) VALUES ('primary', 'strict', 13, 42, 'primary');
