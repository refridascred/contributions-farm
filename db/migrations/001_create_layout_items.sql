-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (ratio, weight, score, state, token) VALUES (58.94, 0.23, 2.21, 'legacy', 'staging');
INSERT INTO layout_items (ratio, weight, score, state, token) VALUES (65.31, 50.96, 79.74, 'latest', 'edge');
