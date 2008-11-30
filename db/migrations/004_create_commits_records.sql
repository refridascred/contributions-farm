-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (state, rank, count, ratio, region) VALUES ('primary', 86, 34, 18.03, 'legacy');
INSERT INTO commits_records (state, rank, count, ratio, region) VALUES ('local', 86, 91, 86.72, 'strict');
