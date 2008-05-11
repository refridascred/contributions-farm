-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (score, state, region) VALUES (97.06, 'fallback', 'strict');
INSERT INTO layout_items (score, state, region) VALUES (64.6, 'eu-west', 'stable');
INSERT INTO layout_items (score, state, region) VALUES (82.01, 'stable', 'edge');
