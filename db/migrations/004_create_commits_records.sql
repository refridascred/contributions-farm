-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (active, rank, state) VALUES (54, 75, 'staging');
INSERT INTO commits_records (active, rank, state) VALUES (91, 89, 'blue');
INSERT INTO commits_records (active, rank, state) VALUES (17, 79, 'strict');
