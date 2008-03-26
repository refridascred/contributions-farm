-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (label, state, owner, region, weight) VALUES ('stable', 'standard', 'eu-west', 'standard', 52.3);
INSERT INTO commits_records (label, state, owner, region, weight) VALUES ('edge', 'local', 'green', 'open', 75.99);
INSERT INTO commits_records (label, state, owner, region, weight) VALUES ('blue', 'green', 'open', 'edge', 22.79);
