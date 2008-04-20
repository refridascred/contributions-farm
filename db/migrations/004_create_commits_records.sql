-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (ratio, state, label, weight, owner) VALUES (75.02, 'latest', 'eu-west', 3.55, 'green');
INSERT INTO commits_records (ratio, state, label, weight, owner) VALUES (97.06, 'fallback', 'local', 67.41, 'legacy');
