-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (state, level, token, weight) VALUES ('primary', 23, 'latest', 39.75);
INSERT INTO commits_records (state, level, token, weight) VALUES ('cached', 52, 'blue', 45.02);
