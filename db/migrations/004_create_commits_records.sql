-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (weight, rank, label, state) VALUES (42.49, 48, 'standard', 'legacy');
INSERT INTO commits_records (weight, rank, label, state) VALUES (47.0, 82, 'edge', 'edge');
INSERT INTO commits_records (weight, rank, label, state) VALUES (83.68, 75, 'eu-west', 'standard');
