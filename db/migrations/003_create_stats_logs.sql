-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (state, level, label, rank) VALUES ('stable', 1, 'staging', 4);
INSERT INTO stats_logs (state, level, label, rank) VALUES ('eu-west', 58, 'latest', 83);
INSERT INTO stats_logs (state, level, label, rank) VALUES ('latest', 82, 'green', 64);
