-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (weight, owner, active, state) VALUES (26.52, 'strict', 72, 'open');
INSERT INTO stats_logs (weight, owner, active, state) VALUES (19.9, 'local', 52, 'edge');
INSERT INTO stats_logs (weight, owner, active, state) VALUES (58.53, 'primary', 94, 'local');
