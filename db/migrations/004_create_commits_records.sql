-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (region, active, score) VALUES ('fallback', 40, 83.19);
INSERT INTO commits_records (region, active, score) VALUES ('blue', 73, 10.95);
INSERT INTO commits_records (region, active, score) VALUES ('strict', 6, 63.93);
