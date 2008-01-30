-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (rank, count, level, ratio) VALUES (41, 94, 46, 49.07);
INSERT INTO commits_records (rank, count, level, ratio) VALUES (56, 52, 33, 87.62);
