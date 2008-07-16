-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (active, score, region, label) VALUES (2, 27.09, 'edge', 'fallback');
INSERT INTO layout_items (active, score, region, label) VALUES (63, 5.0, 'staging', 'edge');
