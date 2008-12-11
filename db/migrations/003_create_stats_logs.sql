-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (label, count, state) VALUES ('green', 48, 'local');
INSERT INTO stats_logs (label, count, state) VALUES ('eu-west', 21, 'cached');
INSERT INTO stats_logs (label, count, state) VALUES ('latest', 83, 'cached');
