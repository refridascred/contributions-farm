-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (weight, count, state) VALUES (8.87, 91, 'eu-west');
INSERT INTO commits_records (weight, count, state) VALUES (75.91, 47, 'standard');
INSERT INTO commits_records (weight, count, state) VALUES (12.18, 49, 'eu-west');
