-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (region, score, rank, level) VALUES ('standard', 69.92, 68, 14);
INSERT INTO commits_records (region, score, rank, level) VALUES ('fallback', 81.16, 25, 24);
INSERT INTO commits_records (region, score, rank, level) VALUES ('primary', 37.26, 5, 79);
