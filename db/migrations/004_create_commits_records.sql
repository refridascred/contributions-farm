-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (region, state, label, weight) VALUES ('latest', 'blue', 'eu-west', 75.34);
INSERT INTO commits_records (region, state, label, weight) VALUES ('eu-west', 'edge', 'cached', 69.93);
INSERT INTO commits_records (region, state, label, weight) VALUES ('staging', 'local', 'latest', 59.55);
