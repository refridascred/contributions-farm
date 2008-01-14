-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (region, state, label, rank, owner) VALUES ('strict', 'green', 'local', 49, 'legacy');
INSERT INTO stats_logs (region, state, label, rank, owner) VALUES ('green', 'stable', 'standard', 39, 'primary');
INSERT INTO stats_logs (region, state, label, rank, owner) VALUES ('eu-west', 'primary', 'latest', 36, 'standard');
