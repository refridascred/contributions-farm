-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (ratio, state, region) VALUES (75.56, 'stable', 'edge');
INSERT INTO layout_items (ratio, state, region) VALUES (72.9, 'standard', 'fallback');
