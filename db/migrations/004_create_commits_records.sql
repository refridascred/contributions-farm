-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (level, count, rank) VALUES (50, 59, 96);
INSERT INTO commits_records (level, count, rank) VALUES (20, 74, 10);
INSERT INTO commits_records (level, count, rank) VALUES (62, 43, 29);
