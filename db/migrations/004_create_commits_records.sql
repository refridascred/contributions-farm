-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, weight, state, rank) VALUES (70.84, 76.98, 'blue', 74);
INSERT INTO commits_records (ratio, weight, state, rank) VALUES (73.82, 87.4, 'standard', 93);
