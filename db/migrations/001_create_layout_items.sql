-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (score, region, token) VALUES (23.0, 'primary', 'fallback');
INSERT INTO layout_items (score, region, token) VALUES (26.4, 'edge', 'standard');
INSERT INTO layout_items (score, region, token) VALUES (98.92, 'open', 'edge');
