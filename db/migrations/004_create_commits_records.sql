-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (ratio, weight, state, level) VALUES (15.4, 30.35, 'strict', 45);
INSERT INTO commits_records (ratio, weight, state, level) VALUES (81.51, 17.68, 'eu-west', 36);
INSERT INTO commits_records (ratio, weight, state, level) VALUES (56.95, 43.35, 'primary', 27);
