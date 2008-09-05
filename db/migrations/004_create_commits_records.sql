-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (rank, level) VALUES (87, 88);
