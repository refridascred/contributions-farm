-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (label, ratio, score, level) VALUES ('strict', 19.81, 49.42, 50);
INSERT INTO commits_records (label, ratio, score, level) VALUES ('standard', 41.81, 12.75, 34);
