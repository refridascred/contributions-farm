-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, label, rank, active) VALUES ('staging', 'local', 55, 40);
INSERT INTO stats_logs (state, label, rank, active) VALUES ('open', 'fallback', 73, 33);
INSERT INTO stats_logs (state, label, rank, active) VALUES ('legacy', 'latest', 19, 53);
