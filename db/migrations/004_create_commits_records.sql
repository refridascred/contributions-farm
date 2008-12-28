-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (count, label, rank, score, level) VALUES (8, 'fallback', 11, 28.13, 29);
INSERT INTO commits_records (count, label, rank, score, level) VALUES (29, 'local', 0, 39.72, 16);
