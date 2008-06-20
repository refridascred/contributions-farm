-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, owner, state) VALUES (49.27, 'blue', 'standard');
INSERT INTO commits_records (weight, owner, state) VALUES (25.21, 'open', 'primary');
INSERT INTO commits_records (weight, owner, state) VALUES (93.8, 'edge', 'fallback');
