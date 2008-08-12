-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (active, rank) VALUES (35, 92);
INSERT INTO commits_records (active, rank) VALUES (29, 8);
INSERT INTO commits_records (active, rank) VALUES (37, 93);
