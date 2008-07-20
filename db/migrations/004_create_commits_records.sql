-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (rank, owner, weight, state, active) VALUES (0, 'legacy', 54.47, 'staging', 43);
INSERT INTO commits_records (rank, owner, weight, state, active) VALUES (40, 'open', 59.86, 'legacy', 88);
INSERT INTO commits_records (rank, owner, weight, state, active) VALUES (32, 'strict', 76.41, 'local', 37);
