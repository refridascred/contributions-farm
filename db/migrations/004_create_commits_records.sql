-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (rank, owner, weight, state, label) VALUES (11, 'cached', 39.57, 'latest', 'primary');
INSERT INTO commits_records (rank, owner, weight, state, label) VALUES (86, 'open', 82.32, 'local', 'stable');
