-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (label, count, rank, score, level) VALUES ('green', 48, 14, 17.06, 64);
INSERT INTO commits_records (label, count, rank, score, level) VALUES ('cached', 4, 27, 85.08, 60);
INSERT INTO commits_records (label, count, rank, score, level) VALUES ('blue', 78, 49, 26.3, 50);
