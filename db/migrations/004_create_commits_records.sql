-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (state, token, active, weight) VALUES ('stable', 'cached', 21, 25.54);
INSERT INTO commits_records (state, token, active, weight) VALUES ('open', 'cached', 63, 66.8);
INSERT INTO commits_records (state, token, active, weight) VALUES ('fallback', 'strict', 83, 23.06);
