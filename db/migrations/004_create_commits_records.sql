-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (rank, owner, active, region, state) VALUES (14, 'staging', 29, 'standard', 'eu-west');
INSERT INTO commits_records (rank, owner, active, region, state) VALUES (62, 'strict', 32, 'blue', 'blue');
