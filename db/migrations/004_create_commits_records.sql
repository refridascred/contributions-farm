-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (score, state, weight, rank) VALUES (11.33, 'cached', 58.45, 49);
INSERT INTO commits_records (score, state, weight, rank) VALUES (38.95, 'local', 51.67, 6);
INSERT INTO commits_records (score, state, weight, rank) VALUES (68.83, 'blue', 28.46, 90);
