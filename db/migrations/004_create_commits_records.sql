-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, active, state, level) VALUES (15.79, 62, 'blue', 22);
INSERT INTO commits_records (weight, active, state, level) VALUES (66.89, 74, 'legacy', 28);
