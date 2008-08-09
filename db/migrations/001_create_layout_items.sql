-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (score, region, label) VALUES (51.96, 'cached', 'cached');
INSERT INTO layout_items (score, region, label) VALUES (60.42, 'legacy', 'open');
