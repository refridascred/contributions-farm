-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (count, rank) VALUES (45, 74);
INSERT INTO commits_records (count, rank) VALUES (72, 10);
INSERT INTO commits_records (count, rank) VALUES (72, 94);
