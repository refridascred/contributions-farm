-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (count, token, state, weight) VALUES (83, 'legacy', 'edge', 42.16);
INSERT INTO commits_records (count, token, state, weight) VALUES (50, 'green', 'eu-west', 77.86);
INSERT INTO commits_records (count, token, state, weight) VALUES (81, 'standard', 'eu-west', 95.82);
