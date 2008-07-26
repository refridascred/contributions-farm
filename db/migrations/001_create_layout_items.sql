-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    weight REAL,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (score, region, weight, token, label) VALUES (47.32, 'cached', 44.6, 'local', 'standard');
INSERT INTO layout_items (score, region, weight, token, label) VALUES (14.23, 'open', 23.55, 'stable', 'open');
INSERT INTO layout_items (score, region, weight, token, label) VALUES (89.4, 'cached', 23.5, 'legacy', 'local');
