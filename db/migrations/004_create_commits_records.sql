-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (ratio, state, weight, rank) VALUES (1.51, 'primary', 39.26, 25);
INSERT INTO commits_records (ratio, state, weight, rank) VALUES (87.35, 'cached', 3.43, 95);
INSERT INTO commits_records (ratio, state, weight, rank) VALUES (58.19, 'local', 56.1, 85);
