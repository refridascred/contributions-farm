-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    rank INTEGER,
    created_at TIMESTAMP,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (active, owner, rank, level) VALUES (57, 'green', 55, 50);
INSERT INTO commits_records (active, owner, rank, level) VALUES (10, 'blue', 67, 74);
