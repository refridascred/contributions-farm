-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (weight, active, state) VALUES (87.07, 13, 'legacy');
INSERT INTO commits_records (weight, active, state) VALUES (77.61, 18, 'legacy');
INSERT INTO commits_records (weight, active, state) VALUES (61.59, 18, 'staging');
