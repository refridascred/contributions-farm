-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (rank, ratio) VALUES (52, 61.28);
INSERT INTO commits_records (rank, ratio) VALUES (38, 6.79);
INSERT INTO commits_records (rank, ratio) VALUES (77, 29.88);
