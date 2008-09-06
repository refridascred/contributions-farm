-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, token, score) VALUES ('legacy', 'legacy', 15.07);
INSERT INTO stats_logs (label, token, score) VALUES ('open', 'blue', 19.59);
INSERT INTO stats_logs (label, token, score) VALUES ('stable', 'strict', 38.31);
