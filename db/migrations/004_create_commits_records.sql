-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (weight, owner, state, level) VALUES (42.91, 'strict', 'standard', 23);
INSERT INTO commits_records (weight, owner, state, level) VALUES (77.63, 'green', 'edge', 1);
INSERT INTO commits_records (weight, owner, state, level) VALUES (47.71, 'open', 'fallback', 68);
