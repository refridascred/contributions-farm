-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (label, active, rank) VALUES ('open', 75, 82);
INSERT INTO stats_logs (label, active, rank) VALUES ('strict', 62, 3);
INSERT INTO stats_logs (label, active, rank) VALUES ('latest', 88, 9);
