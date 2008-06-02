-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    label TEXT,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (weight, owner, label, rank, state) VALUES (78.95, 'strict', 'primary', 57, 'cached');
INSERT INTO commits_records (weight, owner, label, rank, state) VALUES (59.42, 'primary', 'latest', 61, 'fallback');
