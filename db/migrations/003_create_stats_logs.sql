-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, ratio, rank, label) VALUES ('latest', 15.98, 81, 'blue');
INSERT INTO stats_logs (state, ratio, rank, label) VALUES ('strict', 68.38, 34, 'primary');
INSERT INTO stats_logs (state, ratio, rank, label) VALUES ('eu-west', 70.01, 97, 'edge');
