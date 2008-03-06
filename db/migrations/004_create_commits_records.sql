-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (rank, level) VALUES (4, 93);
INSERT INTO commits_records (rank, level) VALUES (57, 42);
INSERT INTO commits_records (rank, level) VALUES (16, 62);
