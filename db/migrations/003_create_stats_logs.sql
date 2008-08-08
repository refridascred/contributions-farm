-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    label TEXT,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (state, token, label, rank, owner) VALUES ('primary', 'open', 'standard', 6, 'cached');
INSERT INTO stats_logs (state, token, label, rank, owner) VALUES ('blue', 'eu-west', 'open', 84, 'blue');
INSERT INTO stats_logs (state, token, label, rank, owner) VALUES ('local', 'latest', 'legacy', 52, 'edge');
