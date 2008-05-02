-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, state, owner) VALUES (26.51, 'green', 'standard');
INSERT INTO commits_records (weight, state, owner) VALUES (68.16, 'primary', 'latest');
