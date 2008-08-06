-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    level INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (score, region, level) VALUES (92.23, 'primary', 6);
INSERT INTO layout_items (score, region, level) VALUES (60.62, 'fallback', 59);
INSERT INTO layout_items (score, region, level) VALUES (61.83, 'fallback', 93);
