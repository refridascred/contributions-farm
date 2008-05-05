-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (region, score, state) VALUES ('fallback', 14.16, 'edge');
INSERT INTO layout_items (region, score, state) VALUES ('standard', 20.22, 'green');
INSERT INTO layout_items (region, score, state) VALUES ('stable', 41.31, 'strict');
