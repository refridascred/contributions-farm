-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    level INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (weight, count, rank, level) VALUES (80.59, 0, 94, 91);
INSERT INTO commits_records (weight, count, rank, level) VALUES (89.49, 33, 3, 10);
