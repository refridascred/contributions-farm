-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    level INTEGER,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (label, level, rank, score) VALUES ('fallback', 53, 21, 97.68);
INSERT INTO commits_records (label, level, rank, score) VALUES ('staging', 92, 50, 81.18);
