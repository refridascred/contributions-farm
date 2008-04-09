-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (active, state, label, region, weight) VALUES (83, 'open', 'open', 'cached', 52.6);
INSERT INTO commits_records (active, state, label, region, weight) VALUES (66, 'cached', 'eu-west', 'legacy', 67.81);
