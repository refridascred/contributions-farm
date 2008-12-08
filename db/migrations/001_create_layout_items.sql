-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (state, count, score, region) VALUES ('latest', 21, 57.68, 'legacy');
INSERT INTO layout_items (state, count, score, region) VALUES ('edge', 81, 89.44, 'latest');
INSERT INTO layout_items (state, count, score, region) VALUES ('standard', 72, 86.48, 'green');
