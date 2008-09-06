-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (level, rank, count, state) VALUES (54, 90, 53, 'green');
INSERT INTO commits_records (level, rank, count, state) VALUES (14, 32, 67, 'open');
INSERT INTO commits_records (level, rank, count, state) VALUES (12, 26, 42, 'green');
