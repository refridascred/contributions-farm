-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (weight, state, owner, score) VALUES (63.11, 'open', 'stable', 64.49);
INSERT INTO commits_records (weight, state, owner, score) VALUES (59.66, 'eu-west', 'primary', 97.05);
