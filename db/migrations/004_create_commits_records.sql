-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, active, state, owner, region) VALUES (13.65, 42, 'latest', 'strict', 'strict');
INSERT INTO commits_records (weight, active, state, owner, region) VALUES (89.57, 97, 'eu-west', 'fallback', 'eu-west');
