-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (weight, region, state, ratio, token) VALUES (7.99, 'edge', 'green', 35.05, 'latest');
INSERT INTO layout_items (weight, region, state, ratio, token) VALUES (64.72, 'legacy', 'standard', 80.05, 'standard');
INSERT INTO layout_items (weight, region, state, ratio, token) VALUES (98.88, 'latest', 'strict', 71.04, 'fallback');
