-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    region TEXT,
    label TEXT,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (region, label, level, score) VALUES ('stable', 'open', 92, 61.67);
INSERT INTO commits_records (region, label, level, score) VALUES ('standard', 'local', 94, 57.89);
