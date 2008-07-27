-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (rank, level, active) VALUES (59, 26, 53);
INSERT INTO commits_records (rank, level, active) VALUES (59, 88, 58);
INSERT INTO commits_records (rank, level, active) VALUES (39, 19, 49);
