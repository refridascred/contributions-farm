-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (owner, state, ratio, weight) VALUES ('blue', 'edge', 42.53, 42.78);
INSERT INTO commits_records (owner, state, ratio, weight) VALUES ('eu-west', 'edge', 98.18, 89.56);
INSERT INTO commits_records (owner, state, ratio, weight) VALUES ('fallback', 'strict', 28.49, 90.42);
