-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (level, rank, count, state) VALUES (71, 25, 63, 'latest');
INSERT INTO commits_records (level, rank, count, state) VALUES (41, 34, 12, 'green');
INSERT INTO commits_records (level, rank, count, state) VALUES (7, 26, 5, 'open');
