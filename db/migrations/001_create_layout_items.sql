-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (score, region, label) VALUES (38.31, 'open', 'blue');
INSERT INTO layout_items (score, region, label) VALUES (24.51, 'legacy', 'green');
INSERT INTO layout_items (score, region, label) VALUES (75.04, 'strict', 'legacy');
